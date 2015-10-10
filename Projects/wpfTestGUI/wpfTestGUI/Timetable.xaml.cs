using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace wpfTestGUI
    {
    /// <summary>
    ///     Interaction logic for Timetable.xaml
    /// </summary>

    //SchoolClasses made for easier and understandable access to classIDlist
    internal enum SchoolClasses
        {
        Ek13A,
        Ek13B,
        Ek14A,
        Ek14B,
        Ek15A,
        Ek15B,
        Hu13,
        Hu14,
        Hu15,
        Na13A,
        Na13B,
        Na13C,
        Na14A,
        Na14B,
        Na15A,
        Na15B,
        Sa13,
        Sa14,
        Sa15A,
        Sa15B
        Te13,
        Te14,
        Te15A,
        Te15B,
    }

    public partial class Timetable
        {
        private readonly List<string> classIDlist = new List<string>();
        private bool mondayDownloaded;

        public Timetable( )
        {
            InitializeComponent();

            DateTime todayTime = DateTime.Today;
            if ( todayTime.DayOfWeek != DayOfWeek.Monday )
            {
                mondayDownloaded = false;
            }

            /*
            This is a very stupid way to do it, because it can change at anytime 
            It is the ID to each class. Added in the list according to the enum SchoolClasses
            */
            classIDlist.Add( "9A2C3C57-CC60-4AF2-8F2E-DA599A7F723E" ); //TE13
            classIDlist.Add( "28834D5E-DC96-4E79-89CB-8E6C3B4CCF0E" ); //TE14
            classIDlist.Add( "F9AF3DC4-EC71-435A-A5AC-E07416383C62" ); //TE15A
            classIDlist.Add( "A9832249-8728-4F6A-8078-F4F6917ADD8E" ); //TE15B
        }

        public void ChangeTimetable( object sender, SelectionChangedEventArgs selectionChangedEventArgs )
        {
            //get combobox
            ComboBox comboItem = sender as ComboBox;

            if ( comboItem == null )
            {
                return;
            }

            //get the selecteditem
            ComboBoxItem cbi = ( ComboBoxItem ) comboItem.SelectedItem;

            //check what class the user selected, download accordingly
            switch ( cbi.Content.ToString() )
            {
                case "Te13":
                    DownloadTimetable( SchoolClasses.Te13, "TE13" );
                    break;
                case "Te14":
                    DownloadTimetable( SchoolClasses.Te14, "TE14" );
                    break;
                case "Te15A":
                    DownloadTimetable( SchoolClasses.Te15A, "TE15A" );
                    break;
                case "Te15B":
                    DownloadTimetable( SchoolClasses.Te15B, "TE15B" );
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        ///     Download the <c>timetable</c> for a specific class id.
        /// </summary>
        /// <param name="classToDownload">Position of class in list.</param>
        /// <param name="fileName">Name of image file</param>
        private void DownloadTimetable( SchoolClasses classToDownload, string fileName )
        {
            //Store our specific classId by using classToDownload.
            string urlId = classIDlist[( int ) classToDownload];

            StringBuilder sb = new StringBuilder();
            sb.Append(
                @"http://www.novasoftware.se/ImgGen/schedulegenerator.aspx?format=png&schoolid=83020/sv-se&type=1&id={" );
            sb.Append( urlId );
            sb.Append(
                @"}&period=&week=&mode=0&printer=0&colors=32&head=0&clock=0&foot=0&day=0&width=1365&height=913&maxwidth=1365&maxheight=913" );

            string urlToDownload = sb.ToString();

            //get location to .exe to later find downloaded image
            string path = Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location );

            if ( File.Exists( path + " / " + fileName + ".png" ) )
            {
                DateTime todayTime = DateTime.Today;

                if ( todayTime.DayOfWeek == DayOfWeek.Monday && mondayDownloaded == false )
                {
                    ForceDownload( urlToDownload, fileName );
                    mondayDownloaded = true;
                }
            }
            else
            {
                using ( WebClient webClient = new WebClient() )
                {
                    //Download timetable to image for future use - cuts download requirement
                    webClient.DownloadFile( new Uri( urlToDownload ), fileName + ".png" );
                }
            }

            //change TimetableImage to downloaded timetable image
            BitmapImage bitmapImage = new BitmapImage( new Uri( path + "/" + fileName + ".png" ) );
            TimetableImage.Source = bitmapImage;
        }

        /// <summary>
        ///     Used when a force refresh is needed.
        /// </summary>
        /// <param name="urlToDownload"></param>
        /// <param name="fileName"></param>
        private static void ForceDownload( string urlToDownload, string fileName )
        {
            using ( WebClient webClient = new WebClient() )
            {
                //Download timetable to image for future use - cuts download requirement
                webClient.DownloadFile( new Uri( urlToDownload ), fileName + ".png" );
            }
        }
        }
    }
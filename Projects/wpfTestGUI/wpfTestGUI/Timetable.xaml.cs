using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Calendar = System.Windows.Controls.Calendar;

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
        Sa15B,
        Te13,
        Te14,
        Te15A,
        Te15B
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
            PopulateList();
            /*
            classIDlist.Add( "9A2C3C57-CC60-4AF2-8F2E-DA599A7F723E" ); //TE13
            classIDlist.Add( "28834D5E-DC96-4E79-89CB-8E6C3B4CCF0E" ); //TE14
            classIDlist.Add( "F9AF3DC4-EC71-435A-A5AC-E07416383C62" ); //TE15A
            classIDlist.Add( "A9832249-8728-4F6A-8078-F4F6917ADD8E" ); //TE15B
            */
        }

        private void PopulateList( )
        {
            string path = Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location );
            if ( !File.Exists( path + "/" + "ClassIDS.txt" ) )
            {
                return;
            }


            using ( StreamReader sr = new StreamReader( path + "/" + "ClassIDS.txt" ) )
            {
                string line;
                while ( ( line = sr.ReadLine() ) != null )
                {
                    var lineSplit = line.Split( '@' );

                    string classId = lineSplit[1];
                    classId = classId.Trim( ' ' );

                    classIDlist.Add( classId );
                }
            }
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
                #region Download ID
                case "Ek13A":
                    DownloadTimetable( SchoolClasses.Ek13A, "EK13A" );
                    break;
                case "Ek13B":
                    DownloadTimetable( SchoolClasses.Ek13B, "EK13B" );
                    break;
                case "Ek14A":
                    DownloadTimetable( SchoolClasses.Ek14A, "EK14A" );
                    break;
                case "Ek14B":
                    DownloadTimetable( SchoolClasses.Ek14B, "EK14B" );
                    break;
                case "Ek15A":
                    DownloadTimetable( SchoolClasses.Ek15A, "EK15A" );
                    break;
                case "Ek15B":
                    DownloadTimetable( SchoolClasses.Ek15B, "EK15B" );
                    break;
                case "Hu13":
                    DownloadTimetable( SchoolClasses.Hu13, "HU13" );
                    break;
                case "Hu14":
                    DownloadTimetable( SchoolClasses.Hu14, "HU14" );
                    break;
                case "Hu15":
                    DownloadTimetable( SchoolClasses.Hu15, "HU15" );
                    break;
                case "Na13A":
                    DownloadTimetable( SchoolClasses.Na13A, "NA13A" );
                    break;
                case "Na13B":
                    DownloadTimetable( SchoolClasses.Na13B, "NA13B" );
                    break;
                case "Na13C":
                    DownloadTimetable( SchoolClasses.Na13C, "NA13C" );
                    break;
                case "Na14A":
                    DownloadTimetable( SchoolClasses.Na14A, "NA14A" );
                    break;
                case "Na14B":
                    DownloadTimetable( SchoolClasses.Na14B, "NA14B" );
                    break;
                case "Na15A":
                    DownloadTimetable( SchoolClasses.Na15A, "NA15A" );
                    break;
                case "Na15B":
                    DownloadTimetable( SchoolClasses.Na15B, "NA15B" );
                    break;
                case "Sa13":
                    DownloadTimetable( SchoolClasses.Sa13, "SA13" );
                    break;
                case "Sa14":
                    DownloadTimetable( SchoolClasses.Sa14, "SA14" );
                    break;
                case "Sa15A":
                    DownloadTimetable( SchoolClasses.Sa15A, "SA15A" );
                    break;
                case "Sa15B":
                    DownloadTimetable( SchoolClasses.Sa15B, "SA15B" );
                    break;
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

                    #endregion
            }
        }

        public static int GetWeekNumber(DateTime dtPassed)
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
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
            DateTime todayTime = DateTime.Today;

            int week = GetWeekNumber( todayTime );

            StringBuilder sb = new StringBuilder();
            sb.Append(
                @"http://www.novasoftware.se/ImgGen/schedulegenerator.aspx?format=png&schoolid=83020/sv-se&type=1&id={" );
            sb.Append( urlId );
            sb.Append( @"}&period=&" );
            sb.Append( "week=" + week + "&" );
            sb.Append(
                "mode=0&printer=0&colors=32&head=0&clock=0&foot=0&day=0&width=1365&height=913&maxwidth=1365&maxheight=913)" );

            string urlToDownload = sb.ToString();

            //get location to .exe to later find downloaded image
            string path = Path.GetDirectoryName( Assembly.GetExecutingAssembly().Location );

            if ( File.Exists( path + "/" + "timetables/"+ fileName + ".png" ) )
            {
                

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
                    webClient.DownloadFile( new Uri( urlToDownload ), path + "/" + "timetables/" + fileName + ".png" );
                }
            }

            //change TimetableImage to downloaded timetable image
            BitmapImage bitmapImage = new BitmapImage( new Uri( path + "/" + "timetables/" + fileName + ".png" ) );
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
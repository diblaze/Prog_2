using System.Linq;

namespace winKryptering
{
    public static class Encrypt
    {
        /// <summary>
        ///     List of vowels.
        /// </summary>
        private static readonly char[] VowelsToCheckFor =
        {
            'a',
            'A',
            'o',
            'O',
            'u',
            'U',
            'å',
            'Å',
            'e',
            'E',
            'i',
            'I',
            'y',
            'Y',
            'ä',
            'Ä',
            'ö',
            'Ö'
        };

        /// <summary>
        ///     Encrypts to the Rövarspråk.
        /// </summary>
        /// <param name="textToEncrypt">The text to encrypt.</param>
        /// <returns>Encrypted text.</returns>
        public static string EncryptToRovar(string textToEncrypt)
        {
            if (textToEncrypt == string.Empty)
            {
                return "Error encrypting the text.";
            }

            string encryptedText = "";

            foreach (char t in textToEncrypt)
            {
                if (char.IsWhiteSpace(t))
                {
                    encryptedText += t;
                }
                else if (VowelsToCheckFor.Contains(t) || char.IsDigit(t) || t == '.' || t == ',')
                {
                    encryptedText += t;
                }
                else
                {
                    encryptedText += t;
                    encryptedText += 'o';
                    encryptedText += t.ToString().ToLower();
                }
            }

            return encryptedText;
        }

        /// <summary>
        ///     Encrypts to the I-språk.
        /// </summary>
        /// <param name="textToEncrypt">The text to encrypt.</param>
        /// <returns>Encrypted text</returns>
        public static string EncryptToILang(string textToEncrypt)
        {
            if (textToEncrypt == string.Empty)
            {
                return "Error encrypting the text.";
            }

            string encryptedText = "";

            foreach (char t in textToEncrypt)
            {
                if (char.IsWhiteSpace(t) || char.IsDigit(t) || t == '.' || t == ',')
                {
                    encryptedText += t;
                }
                else if (VowelsToCheckFor.Contains(t))
                {
                    encryptedText += 'i';
                }
                else
                {
                    encryptedText += t;
                }
            }

            return encryptedText;
        }

        /// <summary>
        ///     Encrypts to Fikonspråket.
        /// </summary>
        /// <param name="textToEncrypt">The text to encrypt.</param>
        /// <returns>Encrypted text</returns>
        public static string EncryptToFikon(string textToEncrypt)
        {
            string encryptedText = "";

            //Split all words by whitespace and put into an array.
            var words = textToEncrypt.Split(' ');

            //foreach word in array, check and convert to fikonspråket.
            foreach (string word in words)
            {
                //holder of first vowel position.
                int locationOfFirstVowel = 0;

                //go through the word until vowel is found.
                for (int i = 0; i < word.Length; i++)
                {
                    //if char is not vowel, skip
                    if (!VowelsToCheckFor.Contains(word[i]))
                    {
                        continue;
                    }

                    //set holder to vowel positon.
                    locationOfFirstVowel = i;
                    break;
                }

                //cut out the part of the word up to the vowel.
                string firstPartOfWord = word.Substring(0, locationOfFirstVowel + 1);
                //cut out the rest of the word after the vowel.
                string secondPartOfWord = word.Substring(locationOfFirstVowel + 1);

                //add "." at the end?
                bool addDot = false;
                //add "," at the end?
                bool addCommas = false;

                //if the second part of the word contains "." then assume it is a dot at the end of the word. 
                //this does not check for if the dots are elsewhere in the word. But if the user follows correct grammar then "." is to end a sentence.
                if (secondPartOfWord.Contains("."))
                {
                    secondPartOfWord = secondPartOfWord.Replace(".", string.Empty);
                    addDot = true;
                }

                //if the second part of the word contains "," then assume it is a comma at the end of the word.
                //this does not check for if the commas are elsewhere in the word. But if the user follows correct grammar then "," is to divide a sentence.
                if (secondPartOfWord.Contains(","))
                {
                    secondPartOfWord = secondPartOfWord.Replace(",", string.Empty);
                    addCommas = true;
                }

                //holder of the finished encrypted word
                string encryptedWord = "";

                if (secondPartOfWord == string.Empty && char.IsUpper(firstPartOfWord[0]))
                {
                    encryptedWord = "Fi" + firstPartOfWord.ToLower() + "kon" + " ";
                }
                else if (secondPartOfWord == string.Empty)
                {
                    encryptedWord = "fi" + firstPartOfWord + "kon" + " ";
                }
                else if (char.IsUpper(firstPartOfWord[0]))
                {
                    //if addDot, assume "." is at the end
                    if (addDot)
                    {
                        encryptedWord = "Fi" + secondPartOfWord + " " + firstPartOfWord.ToLower() + "kon" + ". ";
                    }
                    //if addCommas, assume "," is at the end
                    else if (addCommas)
                    {
                        encryptedWord = "Fi" + secondPartOfWord + " " + firstPartOfWord.ToLower() + "kon" + ", ";
                    }
                    else
                    {
                        encryptedWord = "Fi" + secondPartOfWord + " " + firstPartOfWord.ToLower() + "kon" + " ";
                    }
                }
                else
                {
                    //if addDot, assume "." is at the end
                    if (addDot)
                    {
                        encryptedWord = "fi" + secondPartOfWord + " " + firstPartOfWord + "kon" + ". ";
                    }
                    //if addCommas, assume "," is at the end
                    else if (addCommas)
                    {
                        encryptedWord = "fi" + secondPartOfWord + " " + firstPartOfWord + "kon" + ", ";
                    }
                    else
                    {
                        encryptedWord = "fi" + secondPartOfWord + " " + firstPartOfWord + "kon" + " ";
                    }
                }

                encryptedText += encryptedWord;
            }

            return encryptedText;
        }
    }
}
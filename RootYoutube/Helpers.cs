using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace RootYoutube
{
    public class Helpers
    {
        private readonly static string APPDIR_PATH = @"C:\RootYoutube";

        private readonly static string FILENAME_WITH_APP_PATH = @"C:\RootYoutube\strootyoutube.txt";

        public static string ExampleVideoUrl
        {
            get
            {
                return "Example: https://www.youtube.com/watch?v=KAoQ0KFtvJE";
            }
        }

        public static string VideoTitle(string inputVideoTitle)
        {
            string outputVideoTitle = inputVideoTitle;

            char[] invalidFilenameCharacters = Path.GetInvalidFileNameChars();

            foreach (var invalidFilenameCharacter in invalidFilenameCharacters)
            {
                if (outputVideoTitle.Contains(invalidFilenameCharacter))
                {
                    outputVideoTitle = outputVideoTitle.Replace(invalidFilenameCharacter, '_');
                }
            }

            if (outputVideoTitle.Length > 151)
            {
                outputVideoTitle = string.Concat(outputVideoTitle.Substring(0, 150), "...");
            }

            outputVideoTitle = string.Concat(outputVideoTitle, "_", DateTime.Now.ToString("yyyyMMddHHmmssFFF"));

            return outputVideoTitle.Trim();
        }

        public static string GetYouTubeImageUrl(string videoUrl)
        {
            //  video = https://www.youtube.com/watch?v=KAoQ0KFtvJE | Image = http://img.youtube.com/vi/KAoQ0KFtvJE/2.jpg             

            string youtubeVideoImageUrl = string.Empty;

            int videoUrlLength = videoUrl.Length;
            int youttubeVidKeyIndex = videoUrl.IndexOf("v=");

            if (youttubeVidKeyIndex != -1)
            {
                string strVideoCode = videoUrl.Substring((youttubeVidKeyIndex + 2), videoUrlLength - (youttubeVidKeyIndex + 2));

                youtubeVideoImageUrl = string.Concat("https://img.youtube.com/vi/", strVideoCode, "/default.jpg");
            }

            return youtubeVideoImageUrl;
        }

        public static bool ValidateYoutubeVideoUrl(string youtubeVideoUrl)
        {
            if (youtubeVideoUrl == string.Empty || youtubeVideoUrl == ExampleVideoUrl)
            {                
                return false;
            }

            if (youtubeVideoUrl.Length > 200)
            {
                return false;
            }

            string regExp = @"(https?://(www\.)?youtube\.com/.*v=\w+.*)|(https?://youtu\.be/\w+.*)|(.*src=.https?://(www\.)?youtube\.com/v/\w+.*)|(.*src=.https?://(www\.)?youtube\.com/embed/\w+.*)";

            Regex regex = new Regex(regExp);
            Match match = regex.Match(youtubeVideoUrl);

            if (!match.Success)
            {                
                return false;
            }

            return true;
        }

        /// <summary>
        /// This function creates application directory in C drive and saves input content in file inside.
        /// </summary>
        /// <param name="inputLocationToSave">input content to save in file</param>
        public static void CreateAppPathAndSaveFolderLocation(string inputLocationToSave)
        {
            // Function to store folder location at some place
            
            if (!Directory.Exists(inputLocationToSave.Trim()))
            {
                // If save folder location specified by user does not exist, then exit.
                return;
            }

            if(!CreateApplicationDirectoryPathAndFileInside()) // Create application directory & file inside
            {
                // If file did't exist & application was not able to create directory + file C:\RootYoutube\strootyoutube.txt, then return.
                return;
            }      

            string existingFileContent = File.ReadAllText(FILENAME_WITH_APP_PATH);

            if (!string.Equals(inputLocationToSave.Trim(), existingFileContent.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                // If existing filecontent does not match with new input content, then write new content in the file.
                File.WriteAllText(FILENAME_WITH_APP_PATH, string.Empty); // first clear existing content.

                using (StreamWriter w = File.AppendText(FILENAME_WITH_APP_PATH))
                {
                    w.WriteLine(inputLocationToSave);
                    w.Flush();
                    w.Close();
                }
            }
        }

        /// <summary>
        /// This function creates application directory "RootYoutube" in C drive [C:\RootYoutube]
        /// </summary>
        /// <returns>applicationDirectoryPath</returns>
        private static bool CreateApplicationDirectoryPathAndFileInside()
        {
            bool flag = true;

            try
            {
                if (!Directory.Exists(APPDIR_PATH))
                {
                    // If folder "C:\RootYoutube" does not exist, create it.
                    Directory.CreateDirectory(APPDIR_PATH);                   
                }

                if (!File.Exists(FILENAME_WITH_APP_PATH))
                {
                    // If file does not exist at FILENAME_WITH_APP_PATH location, create it 
                    // Creating this file: [C:\RootYoutube\strootyoutube.txt]
                    File.Create(FILENAME_WITH_APP_PATH).Close();
                }                
            }
            catch (Exception ex)
            {
                flag = false;
            }

            return flag;     
        }

        public static string RetrieveSavedDirectoryPath()
        {
            string existingFileContent = string.Empty;

            // FILENAME_WITH_APP_PATH = C:\RootYoutube\strootyoutube.txt

            if (File.Exists(FILENAME_WITH_APP_PATH))
            {
                existingFileContent = File.ReadAllText(FILENAME_WITH_APP_PATH).Trim();  // [E.g. existingFileContent = D:/Downloads]

                // existingFileContent should contain folder location, so check if it contains valid location or not.
                if (!Directory.Exists(existingFileContent))
                {
                    existingFileContent = string.Empty;
                }
            }
            
            return existingFileContent;  // D:/Downloads                        
        }
    }
}

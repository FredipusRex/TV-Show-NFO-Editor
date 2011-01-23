/*
 * Copyright 2011 Fredipus Rex (Fredipus.Rex@gmail.com)
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *    http://www.apache.org/licenses/LICENSE-2.0
 *    
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NFOApplication
{
    /// <summary>
    /// A class that stores a tag/value pair. Useful for temporarily storing NFO nodes that will
    /// be edited in a grid.
    /// 
    /// A list of valid tags is provided so tag editor grid can populate a drop-down list in the grid.
    /// This ensures only valid tags can be saved to the NFO file. 
    /// 
    /// A set of valid tags that I personally use is hard-coded into the application, but they can be 
    /// overridden by modifying NFOEditor.Tags.config file in the user's AppData folder. That file is 
    /// created the first time the app is run and populated with the set of tags that I personally use, 
    /// but end-users can add additional tags by editing the file. A "valid tags" editor would be a 
    /// fairly simple addition, but not one I currently need.
    /// </summary>
    public class TagValue
    {
        #region Static Tag Configuration

        private static readonly string ConfigFile = Application.UserAppDataPath + @"\\NFOEditor.Tags.config";
        public static List<String> ValidTags { get; set; }

        static TagValue()
        {
            ValidTags = new List<string>();

            // Allow end users to add their own tags - I only have the ones important to me 
            // (a full list of valid tags for TV Shows is hard to find - VideoInfoTag.cpp
            // in the XBMC code is a little unclear).
            if (!System.IO.File.Exists(ConfigFile))
            {
                // The file doesn't exist yet, so just populate it with the tags I care about
                populateWithKnownTags();
           }
            else
            {
                try
                {
                    string[] tags = System.IO.File.ReadAllLines(ConfigFile);
                    ValidTags.AddRange(tags);
                    ValidTags.Sort();
                }
                catch (Exception)
                {
                    // Let the user know we had problems with his tags file and are reverting to built-ins.
                    MessageBox.Show("Error reading tags file. Rebuilding with built-in tags...");
 
                    // The read failed - the file is bad so rebuild it
                    populateWithKnownTags();
                }
            }
        }

        // These are the tags I care about - I'm using "set" to handle groups of extras. It's non-standard
        // but seems to fit the spirit of the concept.
        private static void populateWithKnownTags()
        {
            ValidTags.Add(String.Empty);
            ValidTags.Add("credits");
            ValidTags.Add("director");
            ValidTags.Add("aired");
            ValidTags.Add("composer");
            ValidTags.Add("artist");
            ValidTags.Add("set");
            ValidTags.Sort();
            try
            {
                System.IO.File.WriteAllLines(ConfigFile, ValidTags.ToArray());
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save tags file. Using built-in tags.");
            }
        }

        #endregion

        #region Properties

        // The name of the tag
        public string Tag { get; set; }

        // The value associated with this tag
        public string Value { get; set; }

        #endregion

        #region Constructors

        public TagValue(string tag, string value)
        {
            Tag = tag;
            Value = value;
        }

        public TagValue() : this(String.Empty, String.Empty)
        {
        }

        #endregion
    }

}

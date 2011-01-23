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

namespace NFOApplication
{
    /// <summary>
    /// Stores an actor node. Actor nodes in the XBMC file have up to two sub-nodes
    /// ("name" and "role") and thus can't be handled the same way that simpler
    /// nodes are (via the TagValue class).
    ///
    /// NOTE: I don't support a value for the "actor" node - it's only a parent.
    /// </summary>
    public class Actor
    {
        #region Static Node Names

        public static string Tag { get { return "actor"; } }
        public static string NameTag { get { return "name"; } }
        public static string RoleTag { get { return "role"; } }

        #endregion

        #region Values

        // The value of the "name" node
        public string Name { get; set; }

        // The value of the "role" node
        public string Role { get; set; }

        #endregion

        #region Constructors

        public Actor(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public Actor() : this(String.Empty, String.Empty) { }

        #endregion
    }
}

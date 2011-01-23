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

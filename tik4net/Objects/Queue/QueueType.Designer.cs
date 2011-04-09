//*********************************************************
//  Autogenerated 9.4.2011 15:12:10
//*********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
!re
=.id=*1
=name=default
=kind=pfifo
=pfifo-limit=50
*/
namespace Tik4Net.Objects.Queue
{
    /// <summary>
    /// Represents one row in /queue/type on mikrotik router.
    /// </summary>
    [TikEntity("/queue/type", TikEntityEditMode.Editable)]    
    public sealed partial class QueueType: TikEntityBase
    {
        /// <summary>
        /// Row kind property.
        /// </summary>
        [TikProperty("kind", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Kind 
        { 
            get { return Properties.GetAsStringOrNull("kind"); }
            set { Properties.SetAttribute("kind", value); }
        }

        /// <summary>
        /// Row name property.
        /// </summary>
        [TikProperty("name", typeof(string), true, TikPropertyEditMode.Editable)]
        public string Name 
        { 
            get { return Properties.GetAsString("name"); }
            set { Properties.SetAttribute("name", value); }
        }        	

        /// <summary>
        /// Row pfifo-limit property.
        /// </summary>
        [TikProperty("pfifo-limit", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? PfifoLimit 
        { 
            get { return Properties.GetAsInt64OrNull("pfifo-limit"); }
            set { Properties.SetAttribute("pfifo-limit", value); }
        }        	

        /// <summary>
        /// Row red-avg-packet property.
        /// </summary>
        [TikProperty("red-avg-packet", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? RedAvgPacket 
        { 
            get { return Properties.GetAsInt64OrNull("red-avg-packet"); }
            set { Properties.SetAttribute("red-avg-packet", value); }
        }        	

        /// <summary>
        /// Row red-burst property.
        /// </summary>
        [TikProperty("red-burst", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? RedBurst 
        { 
            get { return Properties.GetAsInt64OrNull("red-burst"); }
            set { Properties.SetAttribute("red-burst", value); }
        }        	

        /// <summary>
        /// Row red-limit property.
        /// </summary>
        [TikProperty("red-limit", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? RedLimit 
        { 
            get { return Properties.GetAsInt64OrNull("red-limit"); }
            set { Properties.SetAttribute("red-limit", value); }
        }        	

        /// <summary>
        /// Row red-max-threshold property.
        /// </summary>
        [TikProperty("red-max-threshold", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? RedMaxThreshold 
        { 
            get { return Properties.GetAsInt64OrNull("red-max-threshold"); }
            set { Properties.SetAttribute("red-max-threshold", value); }
        }        	

        /// <summary>
        /// Row red-min-threshold property.
        /// </summary>
        [TikProperty("red-min-threshold", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? RedMinThreshold 
        { 
            get { return Properties.GetAsInt64OrNull("red-min-threshold"); }
            set { Properties.SetAttribute("red-min-threshold", value); }
        }        	

        /// <summary>
        /// Row sfq-allot property.
        /// </summary>
        [TikProperty("sfq-allot", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? SfqAllot 
        { 
            get { return Properties.GetAsInt64OrNull("sfq-allot"); }
            set { Properties.SetAttribute("sfq-allot", value); }
        }        	

        /// <summary>
        /// Row sfq-perturb property.
        /// </summary>
        [TikProperty("sfq-perturb", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? SfqPerturb 
        { 
            get { return Properties.GetAsInt64OrNull("sfq-perturb"); }
            set { Properties.SetAttribute("sfq-perturb", value); }
        }        	
    }
    
    /// <summary>
    /// Represents list of rows in /queue/type on mikrotik router.
    /// </summary>    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]    
    public sealed partial class QueueTypeList : TikUnorderedList<QueueType>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueueTypeList"/> class.
        /// Default active session (<see cref="TikSession.ActiveSession"/> is used).
        /// </summary>
        public QueueTypeList() 
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueueTypeList"/> class.
        /// </summary>
        /// <param name="session">The session used to access mikrotik.</param>
        public QueueTypeList(TikSession session)
            : base(session)
        {
        }
    }           
}
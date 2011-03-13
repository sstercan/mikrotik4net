//*********************************************************
//  Autogenerated 14.3.2011 0:16:20
//*********************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
!re
=.id=*338
=chain=prerouting
=action=mark-routing
=new-routing-mark=NEPLATIC
=passthrough=true
=protocol=tcp
=src-address=10.43.0.0/16
=dst-address=!10.0.0.0/8
=src-address-list=NEPLATIC
=dst-port=80
=invalid=false
=dynamic=false
=disabled=false
=comment=NEPLATIC - Obcasne presmerovani neplaticu na 10.43.94.200:5000 (d:\WWW\neplatic)
*/
namespace Tik4Net.Objects.Ip.Firewall
{
    /// <summary>
    /// Represents one row in /ip/firewall/mangle on mikrotik router.
    /// </summary>
    [TikEntity("/ip/firewall/mangle", TikEntityEditMode.Editable)]    
    public sealed partial class FirewallMangle: TikEntityBase
    {
        /// <summary>
        /// Row action property.
        /// </summary>
        [TikProperty("action", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Action 
        { 
            get { return Properties.GetAsStringOrNull("action"); }
            set { Properties.SetAttribute("action", value); }
        }

        /// <summary>
        /// Row address-list property.
        /// </summary>
        [TikProperty("address-list", typeof(string), false, TikPropertyEditMode.Editable)]
        public string AddressList 
        { 
            get { return Properties.GetAsStringOrNull("address-list"); }
            set { Properties.SetAttribute("address-list", value); }
        }        	

        /// <summary>
        /// Row address-list-timeout property.
        /// </summary>
        [TikProperty("address-list-timeout", typeof(string), false, TikPropertyEditMode.Editable)]
        public string AddressListTimeout 
        { 
            get { return Properties.GetAsStringOrNull("address-list-timeout"); }
            set { Properties.SetAttribute("address-list-timeout", value); }
        }        	

        /// <summary>
        /// Row comment property.
        /// </summary>
        [TikProperty("comment", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Comment 
        { 
            get { return Properties.GetAsStringOrNull("comment"); }
            set { Properties.SetAttribute("comment", value); }
        }        	

        /// <summary>
        /// Row disabled property.
        /// </summary>
        [TikProperty("disabled", typeof(bool), true, TikPropertyEditMode.Editable)]
        public bool Disabled 
        { 
            get { return Properties.GetAsBoolean("disabled"); }
            set { Properties.SetAttribute("disabled", value); }
        }        	

        /// <summary>
        /// Row dst-address property.
        /// </summary>
        [TikProperty("dst-address", typeof(string), false, TikPropertyEditMode.Editable)]
        public string DstAddress 
        { 
            get { return Properties.GetAsStringOrNull("dst-address"); }
            set { Properties.SetAttribute("dst-address", value); }
        }        	

        /// <summary>
        /// Row dst-address-list property.
        /// </summary>
        [TikProperty("dst-address-list", typeof(string), false, TikPropertyEditMode.Editable)]
        public string DstAddressList 
        { 
            get { return Properties.GetAsStringOrNull("dst-address-list"); }
            set { Properties.SetAttribute("dst-address-list", value); }
        }        	

        /// <summary>
        /// Row dst-port property.
        /// </summary>
        [TikProperty("dst-port", typeof(long?), false, TikPropertyEditMode.Editable)]
        public long? DstPort 
        { 
            get { return Properties.GetAsInt64OrNull("dst-port"); }
            set { Properties.SetAttribute("dst-port", value); }
        }        	

        /// <summary>
        /// Row dynamic property.
        /// </summary>
        [TikProperty("dynamic", typeof(bool?), false, TikPropertyEditMode.Editable)]
        public bool? Dynamic 
        { 
            get { return Properties.GetAsBooleanOrNull("dynamic"); }
            set { Properties.SetAttribute("dynamic", value); }
        }        	

        /// <summary>
        /// Row chain property.
        /// </summary>
        [TikProperty("chain", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Chain 
        { 
            get { return Properties.GetAsStringOrNull("chain"); }
            set { Properties.SetAttribute("chain", value); }
        }        	

        /// <summary>
        /// Row in-interface property.
        /// </summary>
        [TikProperty("in-interface", typeof(string), false, TikPropertyEditMode.Editable)]
        public string InInterface 
        { 
            get { return Properties.GetAsStringOrNull("in-interface"); }
            set { Properties.SetAttribute("in-interface", value); }
        }        	

        /// <summary>
        /// Row invalid property.
        /// </summary>
        [TikProperty("invalid", typeof(bool?), false, TikPropertyEditMode.Editable)]
        public bool? Invalid 
        { 
            get { return Properties.GetAsBooleanOrNull("invalid"); }
            set { Properties.SetAttribute("invalid", value); }
        }        	

        /// <summary>
        /// Row new-packet-mark property.
        /// </summary>
        [TikProperty("new-packet-mark", typeof(string), false, TikPropertyEditMode.Editable)]
        public string NewPacketMark 
        { 
            get { return Properties.GetAsStringOrNull("new-packet-mark"); }
            set { Properties.SetAttribute("new-packet-mark", value); }
        }        	

        /// <summary>
        /// Row new-routing-mark property.
        /// </summary>
        [TikProperty("new-routing-mark", typeof(string), false, TikPropertyEditMode.Editable)]
        public string NewRoutingMark 
        { 
            get { return Properties.GetAsStringOrNull("new-routing-mark"); }
            set { Properties.SetAttribute("new-routing-mark", value); }
        }        	

        /// <summary>
        /// Row passthrough property.
        /// </summary>
        [TikProperty("passthrough", typeof(bool?), false, TikPropertyEditMode.Editable)]
        public bool? Passthrough 
        { 
            get { return Properties.GetAsBooleanOrNull("passthrough"); }
            set { Properties.SetAttribute("passthrough", value); }
        }        	

        /// <summary>
        /// Row protocol property.
        /// </summary>
        [TikProperty("protocol", typeof(string), false, TikPropertyEditMode.Editable)]
        public string Protocol 
        { 
            get { return Properties.GetAsStringOrNull("protocol"); }
            set { Properties.SetAttribute("protocol", value); }
        }        	

        /// <summary>
        /// Row routing-mark property.
        /// </summary>
        [TikProperty("routing-mark", typeof(string), false, TikPropertyEditMode.Editable)]
        public string RoutingMark 
        { 
            get { return Properties.GetAsStringOrNull("routing-mark"); }
            set { Properties.SetAttribute("routing-mark", value); }
        }        	

        /// <summary>
        /// Row src-address property.
        /// </summary>
        [TikProperty("src-address", typeof(string), false, TikPropertyEditMode.Editable)]
        public string SrcAddress 
        { 
            get { return Properties.GetAsStringOrNull("src-address"); }
            set { Properties.SetAttribute("src-address", value); }
        }        	

        /// <summary>
        /// Row src-address-list property.
        /// </summary>
        [TikProperty("src-address-list", typeof(string), false, TikPropertyEditMode.Editable)]
        public string SrcAddressList 
        { 
            get { return Properties.GetAsStringOrNull("src-address-list"); }
            set { Properties.SetAttribute("src-address-list", value); }
        }        	

        /// <summary>
        /// Row tcp-flags property.
        /// </summary>
        [TikProperty("tcp-flags", typeof(string), false, TikPropertyEditMode.Editable)]
        public string TcpFlags 
        { 
            get { return Properties.GetAsStringOrNull("tcp-flags"); }
            set { Properties.SetAttribute("tcp-flags", value); }
        }        	

        /// <summary>
        /// Row jump-target property.
        /// </summary>
        [TikProperty("jump-target", typeof(string), false, TikPropertyEditMode.Editable)]
        public string JumpTarget 
        { 
            get { return Properties.GetAsStringOrNull("jump-target"); }
            set { Properties.SetAttribute("jump-target", value); }
        }        	
    }
    
    /// <summary>
    /// Represents list of rows in /ip/firewall/mangle on mikrotik router.
    /// </summary>    
    [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1710:IdentifiersShouldHaveCorrectSuffix")]    
    public sealed partial class FirewallMangleList : TikList<FirewallMangle>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallMangleList"/> class.
        /// Default active session (<see cref="TikSession.ActiveSession"/> is used).
        /// </summary>
        public FirewallMangleList() 
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirewallMangleList"/> class.
        /// </summary>
        /// <param name="session">The session used to access mikrotik.</param>
        public FirewallMangleList(TikSession session)
            : base(session)
        {
        }
    }           
}
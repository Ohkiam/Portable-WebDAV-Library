﻿using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace DecaTec.WebDav.WebDavArtifacts
{
    /// <summary>
    /// Class representing an 'prop' XML element for WebDAV communication.
    /// This class contains all properties defined in RFC4918, but property names are not limited to these properties.
    /// </summary>
    [DataContract]
    [XmlType(TypeName = WebDavConstants.Prop, Namespace = WebDavConstants.DAV)]
    [XmlRoot(Namespace = WebDavConstants.DAV, IsNullable = false)]
    public class Prop
    {
        /// <summary>
        /// Creates a Prop with empty properties. This is especially useful for PROPFIND commands where only specific properties should be requested.
        /// </summary>
        /// <param name="emptyPropertyNames">The name of the properties of the Prop which should be empty.</param>
        /// <returns>A Prop with the empty properties which where requested.</returns>
        /// <remarks>As an example, if a PROPFIND command should be sent returning only the getlastaccess property, you can use the following code:
        /// 
        /// <code>
        /// PropFind pf = new PropFind();
        /// Prop p = Prop.CreatePropWithEmptyProperties("getlastmodified");
        /// pf.Item = p;
        ///  </code>
        ///  
        /// This PropFind object can then be used in a PROPFIND command on the WebDavClient.
        /// 
        /// This implementation of Prop contains all properties defined in RFC4918. If you need to request other properties from a WebDav server, you will need 
        /// to implement your own classes which can be (de-)serialized for communication with the server.
        /// </remarks>
        public static Prop CreatePropWithEmptyProperties(params string[] emptyPropertyNames)
        {
            Prop prop = new Prop();

            foreach (var emptyPropertyName in emptyPropertyNames)
            {
                switch (emptyPropertyName.ToLower())
                {
                    case PropNameConstants.CreationDate:
                        prop.CreationDate = string.Empty;
                        break;        
                    case PropNameConstants.GetContentLanguage:
                        prop.GetContentLanguage = string.Empty;
                        break;
                    case PropNameConstants.DisplayName:
                        prop.DisplayName = string.Empty;
                        break;
                    case PropNameConstants.GetContentLength:
                        prop.GetContentLength = string.Empty;
                        break;
                    case PropNameConstants.GetContentType:
                        prop.GetContentType = string.Empty;
                        break;
                    case PropNameConstants.GetLastModified:
                        prop.GetLastModified = string.Empty;
                        break;
                    case PropNameConstants.GetEtag:
                        prop.GetEtag = string.Empty;
                        break;
                    case PropNameConstants.Source:
                        prop.Source = new Source();
                        break;
                    case PropNameConstants.ResourceType:
                        prop.ResourceType = new ResourceType();
                        break;
                    case PropNameConstants.ContentClass:
                        prop.ContentClass = string.Empty;
                        break;
                    case PropNameConstants.DefaultDocument:
                        prop.DefaultDocument = string.Empty;
                        break;
                    case PropNameConstants.Href:
                        prop.Href = string.Empty;
                        break;
                    case PropNameConstants.IsCollection:
                        prop.IsCollection = string.Empty;
                        break;
                    case PropNameConstants.IsHidden:
                        prop.IsHidden = string.Empty;
                        break;
                    case PropNameConstants.IsReadonly:
                        prop.IsReadonly = string.Empty;
                        break;
                    case PropNameConstants.IsRoot:
                        prop.IsRoot = string.Empty;
                        break;
                    case PropNameConstants.IsStructuredDocument:
                        prop.IsStructuredDocument = string.Empty;
                        break;
                    case PropNameConstants.LastAccessed:
                        prop.LastAccessed = string.Empty;
                        break;
                    case PropNameConstants.Name:
                        prop.Name = string.Empty;
                        break;
                    case PropNameConstants.ParentName:
                        prop.ParentName = string.Empty;
                        break;
                    case PropNameConstants.SupportedLock:
                        prop.SupportedLock = new SupportedLock();
                        break;
                    case PropNameConstants.QuotaAvailableBytes:
                        prop.QuotaAvailableBytes = string.Empty;
                        break;
                    case PropNameConstants.QuotaUsedBytes:
                        prop.QuotaUsedBytes = string.Empty;
                        break;
                    case PropNameConstants.LockDiscovery:
                        prop.LockDiscovery = new LockDiscovery();
                        break;
                    default:
                        break;
                }
            }

            return prop;
        }

        /// <summary>
        /// Creates a Prop with all empty properties which are defined in RFC4918. This is especially useful for PROPFIND commands when the so called 'allprop' cannot be used because the WebDAV server does not return all properties.
        /// </summary>
        /// <returns>A Prop with all empty properties defined in RFC4918.</returns>
        public static Prop CreatePropWithEmptyPropertiesAll()
        {
            Prop prop = new Prop();
            prop.CreationDate = string.Empty;
            prop.GetContentLanguage = string.Empty;
            prop.DisplayName = string.Empty;
            prop.GetContentLength = string.Empty;
            prop.GetContentType = string.Empty;
            prop.GetLastModified = string.Empty;
            prop.GetEtag = string.Empty;
            prop.Source = new Source();
            prop.ResourceType = new ResourceType();
            prop.ContentClass = string.Empty;
            prop.DefaultDocument = string.Empty;
            prop.Href = string.Empty;
            prop.IsCollection = string.Empty;
            prop.IsHidden = string.Empty;
            prop.IsReadonly = string.Empty;
            prop.IsRoot = string.Empty;
            prop.IsStructuredDocument = string.Empty;
            prop.LastAccessed = string.Empty;
            prop.Name = string.Empty;
            prop.ParentName = string.Empty;
            prop.SupportedLock = new SupportedLock();
            prop.QuotaAvailableBytes = string.Empty;
            prop.QuotaUsedBytes = string.Empty;
            prop.LockDiscovery = new LockDiscovery();
            return prop;
        }       

        /// <summary>
        /// Gets or sets the CreationDate.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.CreationDate)]
        public string CreationDate
        {
            get;
            set;
        }

        /// <summary>
        /// gets or sets the CreationDateSpecified.
        /// </summary>
        [XmlIgnore]
        public bool CreationDateSpecified
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GetContentLanguage.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.GetContentLanguage)]
        public string GetContentLanguage
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DisplayName.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.DisplayName)]
        public string DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GetContentLength.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.GetContentLength)]
        public string GetContentLength
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GetContentType.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.GetContentType)]
        public string GetContentType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GetLastModified.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.GetLastModified)]
        public string GetLastModified
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GetEtag.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.GetEtag)]
        public string GetEtag
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DecaTec.WebDav.WebDavArtifacts.Source"/>.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.Source)]
        public Source Source
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DecaTec.WebDav.WebDavArtifacts.ResourceType"/>.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.ResourceType)]
        public ResourceType ResourceType
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the GetContentClass.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.ContentClass)]
        public string ContentClass
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the DefaultDocument.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.DefaultDocument)]
        public string DefaultDocument
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Href.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.Href)]
        public string Href
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsCollection.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.IsCollection)]
        public string IsCollection
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsHidden.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.IsHidden)]
        public string IsHidden
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsReadOnly.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.IsReadonly)]
        public string IsReadonly
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsRoot.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.IsRoot)]
        public string IsRoot
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the IsStructuredDocument.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.IsStructuredDocument)]
        public string IsStructuredDocument
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the LastAccessed.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.LastAccessed)]
        public string LastAccessed
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.Name)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the ParentName.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.ParentName)]
        public string ParentName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DecaTec.WebDav.WebDavArtifacts.LockDiscovery"/>.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.LockDiscovery)]
        public LockDiscovery LockDiscovery
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the <see cref="DecaTec.WebDav.WebDavArtifacts.SupportedLock"/>.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.SupportedLock)]
        public SupportedLock SupportedLock
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the xml:lang attribute.
        /// </summary>
        [XmlAttribute(WebDavConstants.XmlLangAttribute)]
        public string Language
        {
            get;
            set;
        }

        #region Extension RFC4331

        /// <summary>
        /// Gets or sets the QuotaAvailableBytes.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.QuotaAvailableBytes)]
        public string QuotaAvailableBytes
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the QuotaUsedBytes.
        /// </summary>
        [XmlElement(ElementName = PropNameConstants.QuotaUsedBytes)]
        public string QuotaUsedBytes
        {
            get;
            set;
        }

        #endregion Extension RFC4331
    }
}

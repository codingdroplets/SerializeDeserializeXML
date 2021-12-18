# Serialize & Deserialize XML in C#

Watch Tutorial Video:
https://www.youtube.com/watch?v=sE3dUxpEvNg

The video explains about the serialization of objects or a list of objects in XML format and deserialization of an XML file or XML String back to an object or a list of objects. 

Serialization is a process by which an object's state is transformed in some serial data format, such as XML or binary format. 
Deserialization, on the other hand, is used to convert the byte of data, such as XML or binary data, to object type. 

Serialization is the process of converting an object into a form that can be readily transported. For example, you can serialize an object and transport it over the Internet using HTTP between a client and a server. 
On the other end, deserialization reconstructs the object from the stream. XML serialization results in strongly typed classes with public properties and fields that are converted to a serial format (in this case, XML) for storage or transport.

The XmlSerializer object helps us to serialize and deserialize an objects or a list of objects into and from XML documents. Also, the XmlSerializer enables us to control how objects are encoded into XML.

Topics covered in the video:
1 - Serializing XML String/XML File from a C# Object [C# XML Serialize / XML Serialize C#]
2 - Deserializing a C# Object from a XML String/XML File [C# XML Deserialize / XML Deserialize C#]
3 - Serializing XML String/XML File from a list of objects [List to XML C#]
4 - Deserializing list of objects from a XML String/XML File [XML to List C#]
5 - Attributes that can be used for XML Serialization and Deserialization

Attributes can be used to control the XML serialization of an object or to create an alternate XML stream from the same set of classes.
Using the XmlSerializer, you can generate more than one XML stream with the same set of classes. You might want to do this because two different XML Web services require the same basic information, with only slight differences.

XmlRoot Attribute:
The XmlRootAttribute allows you to set an alternate name for the root of the XML element, the element namespace. By default, the XmlSerializer uses the class name. The attribute also allows you to set the XML namespace for the element.

XmlElement Attribute:
Indicates that a public field or property represents an XML element when the XmlSerializer serializes or deserializes the object that contains it.

XmlIgnore Attribute:
There might be situations when a public property or field does not need to be serialized. For example, a field or property could be used to contain metadata. In such cases, apply the XmlIgnoreAttribute to the field or property and the XmlSerializer will skip over it.

XmlAttribute Attribute:
The XmlAttribute instructs the XmlSerializer to serialize the Name field as an XML attribute instead of an XML element (the default behavior).

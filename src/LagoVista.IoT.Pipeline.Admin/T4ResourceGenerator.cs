﻿using System.Globalization;
using System.Reflection;

//Resources:PipelineAdminResources:Common_Description
namespace LagoVista.IoT.Pipeline.Admin.Resources
{
	public class PipelineAdminResources
	{
        private static global::System.Resources.ResourceManager _resourceManager;
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static global::System.Resources.ResourceManager ResourceManager 
		{
            get 
			{
                if (object.ReferenceEquals(_resourceManager, null)) 
				{
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("LagoVista.IoT.Pipeline.Admin.Resources.PipelineAdminResources", typeof(PipelineAdminResources).GetTypeInfo().Assembly);
                    _resourceManager = temp;
                }
                return _resourceManager;
            }
        }
        
        /// <summary>
        ///   Returns the formatted resource string.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static string GetResourceString(string key, params string[] tokens)
		{
			var culture = CultureInfo.CurrentCulture;;
            var str = ResourceManager.GetString(key, culture);

			for(int i = 0; i < tokens.Length; i += 2)
				str = str.Replace(tokens[i], tokens[i+1]);
										
            return str;
        }
        
        /// <summary>
        ///   Returns the formatted resource string.
        /// </summary>
		/*
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        private static HtmlString GetResourceHtmlString(string key, params string[] tokens)
		{
			var str = GetResourceString(key, tokens);
							
			if(str.StartsWith("HTML:"))
				str = str.Substring(5);

			return new HtmlString(str);
        }*/
		
		public static string Common_Description { get { return GetResourceString("Common_Description"); } }
//Resources:PipelineAdminResources:Common_IsPublic

		public static string Common_IsPublic { get { return GetResourceString("Common_IsPublic"); } }
//Resources:PipelineAdminResources:Common_Key

		public static string Common_Key { get { return GetResourceString("Common_Key"); } }
//Resources:PipelineAdminResources:Common_Key_Help

		public static string Common_Key_Help { get { return GetResourceString("Common_Key_Help"); } }
//Resources:PipelineAdminResources:Common_Key_Validation

		public static string Common_Key_Validation { get { return GetResourceString("Common_Key_Validation"); } }
//Resources:PipelineAdminResources:Common_Name

		public static string Common_Name { get { return GetResourceString("Common_Name"); } }
//Resources:PipelineAdminResources:Common_Notes

		public static string Common_Notes { get { return GetResourceString("Common_Notes"); } }
//Resources:PipelineAdminResources:Common_Script

		public static string Common_Script { get { return GetResourceString("Common_Script"); } }
//Resources:PipelineAdminResources:Connection_Select_Type

		public static string Connection_Select_Type { get { return GetResourceString("Connection_Select_Type"); } }
//Resources:PipelineAdminResources:Connection_Type_AMQP

		public static string Connection_Type_AMQP { get { return GetResourceString("Connection_Type_AMQP"); } }
//Resources:PipelineAdminResources:Connection_Type_AzureEventHub

		public static string Connection_Type_AzureEventHub { get { return GetResourceString("Connection_Type_AzureEventHub"); } }
//Resources:PipelineAdminResources:Connection_Type_AzureIoTHub

		public static string Connection_Type_AzureIoTHub { get { return GetResourceString("Connection_Type_AzureIoTHub"); } }
//Resources:PipelineAdminResources:Connection_Type_AzureServiceBus

		public static string Connection_Type_AzureServiceBus { get { return GetResourceString("Connection_Type_AzureServiceBus"); } }
//Resources:PipelineAdminResources:Connection_Type_Custom

		public static string Connection_Type_Custom { get { return GetResourceString("Connection_Type_Custom"); } }
//Resources:PipelineAdminResources:Connection_Type_MQTT

		public static string Connection_Type_MQTT { get { return GetResourceString("Connection_Type_MQTT"); } }
//Resources:PipelineAdminResources:Connection_Type_POP3Server

		public static string Connection_Type_POP3Server { get { return GetResourceString("Connection_Type_POP3Server"); } }
//Resources:PipelineAdminResources:Connection_Type_Rest

		public static string Connection_Type_Rest { get { return GetResourceString("Connection_Type_Rest"); } }
//Resources:PipelineAdminResources:Connection_Type_Soap

		public static string Connection_Type_Soap { get { return GetResourceString("Connection_Type_Soap"); } }
//Resources:PipelineAdminResources:Connection_Type_TCP

		public static string Connection_Type_TCP { get { return GetResourceString("Connection_Type_TCP"); } }
//Resources:PipelineAdminResources:Connection_Type_UDP

		public static string Connection_Type_UDP { get { return GetResourceString("Connection_Type_UDP"); } }
//Resources:PipelineAdminResources:CustomModule_Description

		public static string CustomModule_Description { get { return GetResourceString("CustomModule_Description"); } }
//Resources:PipelineAdminResources:CustomModule_Help

		public static string CustomModule_Help { get { return GetResourceString("CustomModule_Help"); } }
//Resources:PipelineAdminResources:CustomModule_Title

		public static string CustomModule_Title { get { return GetResourceString("CustomModule_Title"); } }
//Resources:PipelineAdminResources:InputTranslator_DelimiterSquence_Help

		public static string InputTranslator_DelimiterSquence_Help { get { return GetResourceString("InputTranslator_DelimiterSquence_Help"); } }
//Resources:PipelineAdminResources:InputTranslator_DelimterSequence

		public static string InputTranslator_DelimterSequence { get { return GetResourceString("InputTranslator_DelimterSequence"); } }
//Resources:PipelineAdminResources:InputTranslator_Description

		public static string InputTranslator_Description { get { return GetResourceString("InputTranslator_Description"); } }
//Resources:PipelineAdminResources:InputTranslator_Help

		public static string InputTranslator_Help { get { return GetResourceString("InputTranslator_Help"); } }
//Resources:PipelineAdminResources:InputTranslator_Title

		public static string InputTranslator_Title { get { return GetResourceString("InputTranslator_Title"); } }
//Resources:PipelineAdminResources:InputTranslator_TranslatorType

		public static string InputTranslator_TranslatorType { get { return GetResourceString("InputTranslator_TranslatorType"); } }
//Resources:PipelineAdminResources:InputTranslator_TranslatorType_Select

		public static string InputTranslator_TranslatorType_Select { get { return GetResourceString("InputTranslator_TranslatorType_Select"); } }
//Resources:PipelineAdminResources:Listener_Description

		public static string Listener_Description { get { return GetResourceString("Listener_Description"); } }
//Resources:PipelineAdminResources:Listener_EndMessageSequence

		public static string Listener_EndMessageSequence { get { return GetResourceString("Listener_EndMessageSequence"); } }
//Resources:PipelineAdminResources:Listener_EndMessageSequence_Help

		public static string Listener_EndMessageSequence_Help { get { return GetResourceString("Listener_EndMessageSequence_Help"); } }
//Resources:PipelineAdminResources:Listener_Endpoint

		public static string Listener_Endpoint { get { return GetResourceString("Listener_Endpoint"); } }
//Resources:PipelineAdminResources:Listener_Help

		public static string Listener_Help { get { return GetResourceString("Listener_Help"); } }
//Resources:PipelineAdminResources:Listener_KeepAliveToSendReply

		public static string Listener_KeepAliveToSendReply { get { return GetResourceString("Listener_KeepAliveToSendReply"); } }
//Resources:PipelineAdminResources:Listener_KeepAliveToSendReplyTimeout

		public static string Listener_KeepAliveToSendReplyTimeout { get { return GetResourceString("Listener_KeepAliveToSendReplyTimeout"); } }
//Resources:PipelineAdminResources:Listener_ListenerType

		public static string Listener_ListenerType { get { return GetResourceString("Listener_ListenerType"); } }
//Resources:PipelineAdminResources:Listener_MaxMessageSize

		public static string Listener_MaxMessageSize { get { return GetResourceString("Listener_MaxMessageSize"); } }
//Resources:PipelineAdminResources:Listener_MaxMessageSize_Help

		public static string Listener_MaxMessageSize_Help { get { return GetResourceString("Listener_MaxMessageSize_Help"); } }
//Resources:PipelineAdminResources:Listener_MessageReceivedTimeout

		public static string Listener_MessageReceivedTimeout { get { return GetResourceString("Listener_MessageReceivedTimeout"); } }
//Resources:PipelineAdminResources:Listener_MessageReceivedTimeout_Help

		public static string Listener_MessageReceivedTimeout_Help { get { return GetResourceString("Listener_MessageReceivedTimeout_Help"); } }
//Resources:PipelineAdminResources:Listener_Port

		public static string Listener_Port { get { return GetResourceString("Listener_Port"); } }
//Resources:PipelineAdminResources:Listener_Port_Help

		public static string Listener_Port_Help { get { return GetResourceString("Listener_Port_Help"); } }
//Resources:PipelineAdminResources:Listener_StartMessageSequence

		public static string Listener_StartMessageSequence { get { return GetResourceString("Listener_StartMessageSequence"); } }
//Resources:PipelineAdminResources:Listener_StartMessageSequence_Help

		public static string Listener_StartMessageSequence_Help { get { return GetResourceString("Listener_StartMessageSequence_Help"); } }
//Resources:PipelineAdminResources:Listener_Title

		public static string Listener_Title { get { return GetResourceString("Listener_Title"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType

		public static string MessageFieldParserConfiguration_BinaryType { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Boolean

		public static string MessageFieldParserConfiguration_BinaryType_Boolean { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Boolean"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Char

		public static string MessageFieldParserConfiguration_BinaryType_Char { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Char"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_DoublePrecisionFloatingPoint

		public static string MessageFieldParserConfiguration_BinaryType_DoublePrecisionFloatingPoint { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_DoublePrecisionFloatingPoint"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Int16BigEndian

		public static string MessageFieldParserConfiguration_BinaryType_Int16BigEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Int16BigEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Int16LittleEndian

		public static string MessageFieldParserConfiguration_BinaryType_Int16LittleEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Int16LittleEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Int32BigEndian

		public static string MessageFieldParserConfiguration_BinaryType_Int32BigEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Int32BigEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Int32LittleEndian

		public static string MessageFieldParserConfiguration_BinaryType_Int32LittleEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Int32LittleEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Int64BigEndian

		public static string MessageFieldParserConfiguration_BinaryType_Int64BigEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Int64BigEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Int64LittleEndian

		public static string MessageFieldParserConfiguration_BinaryType_Int64LittleEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Int64LittleEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_Int8

		public static string MessageFieldParserConfiguration_BinaryType_Int8 { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_Int8"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_SelectDataType

		public static string MessageFieldParserConfiguration_BinaryType_SelectDataType { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_SelectDataType"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_SelectDataType_Help

		public static string MessageFieldParserConfiguration_BinaryType_SelectDataType_Help { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_SelectDataType_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_SinglePrecisionFloatingPoint

		public static string MessageFieldParserConfiguration_BinaryType_SinglePrecisionFloatingPoint { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_SinglePrecisionFloatingPoint"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_String

		public static string MessageFieldParserConfiguration_BinaryType_String { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_String"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_UInt16BigEndian

		public static string MessageFieldParserConfiguration_BinaryType_UInt16BigEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_UInt16BigEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_UInt16LittleEndian

		public static string MessageFieldParserConfiguration_BinaryType_UInt16LittleEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_UInt16LittleEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_UInt32BigEndian

		public static string MessageFieldParserConfiguration_BinaryType_UInt32BigEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_UInt32BigEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_UInt32LittleEndian

		public static string MessageFieldParserConfiguration_BinaryType_UInt32LittleEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_UInt32LittleEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_UInt64BigEndian

		public static string MessageFieldParserConfiguration_BinaryType_UInt64BigEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_UInt64BigEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_UInt64LittleEndian

		public static string MessageFieldParserConfiguration_BinaryType_UInt64LittleEndian { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_UInt64LittleEndian"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_BinaryType_UInt8

		public static string MessageFieldParserConfiguration_BinaryType_UInt8 { get { return GetResourceString("MessageFieldParserConfiguration_BinaryType_UInt8"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_DelimitedColumnIndex

		public static string MessageFieldParserConfiguration_DelimitedColumnIndex { get { return GetResourceString("MessageFieldParserConfiguration_DelimitedColumnIndex"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_DelimitedColumnIndex_Help

		public static string MessageFieldParserConfiguration_DelimitedColumnIndex_Help { get { return GetResourceString("MessageFieldParserConfiguration_DelimitedColumnIndex_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_Delimiter

		public static string MessageFieldParserConfiguration_Delimiter { get { return GetResourceString("MessageFieldParserConfiguration_Delimiter"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_Delimitor_Help

		public static string MessageFieldParserConfiguration_Delimitor_Help { get { return GetResourceString("MessageFieldParserConfiguration_Delimitor_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_Description

		public static string MessageFieldParserConfiguration_Description { get { return GetResourceString("MessageFieldParserConfiguration_Description"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_Help

		public static string MessageFieldParserConfiguration_Help { get { return GetResourceString("MessageFieldParserConfiguration_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_KeyName

		public static string MessageFieldParserConfiguration_KeyName { get { return GetResourceString("MessageFieldParserConfiguration_KeyName"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_KeyName_Help

		public static string MessageFieldParserConfiguration_KeyName_Help { get { return GetResourceString("MessageFieldParserConfiguration_KeyName_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_Length

		public static string MessageFieldParserConfiguration_Length { get { return GetResourceString("MessageFieldParserConfiguration_Length"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_OutputType

		public static string MessageFieldParserConfiguration_OutputType { get { return GetResourceString("MessageFieldParserConfiguration_OutputType"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_OutputType_Boolean

		public static string MessageFieldParserConfiguration_OutputType_Boolean { get { return GetResourceString("MessageFieldParserConfiguration_OutputType_Boolean"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_OutputType_FloatingPoint

		public static string MessageFieldParserConfiguration_OutputType_FloatingPoint { get { return GetResourceString("MessageFieldParserConfiguration_OutputType_FloatingPoint"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_OutputType_Integer

		public static string MessageFieldParserConfiguration_OutputType_Integer { get { return GetResourceString("MessageFieldParserConfiguration_OutputType_Integer"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_OutputType_SelectDataType

		public static string MessageFieldParserConfiguration_OutputType_SelectDataType { get { return GetResourceString("MessageFieldParserConfiguration_OutputType_SelectDataType"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_OutputType_SelectDataType_Help

		public static string MessageFieldParserConfiguration_OutputType_SelectDataType_Help { get { return GetResourceString("MessageFieldParserConfiguration_OutputType_SelectDataType_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_OutputType_String

		public static string MessageFieldParserConfiguration_OutputType_String { get { return GetResourceString("MessageFieldParserConfiguration_OutputType_String"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy

		public static string MessageFieldParserConfiguration_ParserStrategy { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_Delimited

		public static string MessageFieldParserConfiguration_ParserStrategy_Delimited { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_Delimited"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_Header

		public static string MessageFieldParserConfiguration_ParserStrategy_Header { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_Header"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_Help

		public static string MessageFieldParserConfiguration_ParserStrategy_Help { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_JsonProperty

		public static string MessageFieldParserConfiguration_ParserStrategy_JsonProperty { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_JsonProperty"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_Position

		public static string MessageFieldParserConfiguration_ParserStrategy_Position { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_Position"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_RegEx

		public static string MessageFieldParserConfiguration_ParserStrategy_RegEx { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_RegEx"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_RegExHeader

		public static string MessageFieldParserConfiguration_ParserStrategy_RegExHeader { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_RegExHeader"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_RegExHeader_Help

		public static string MessageFieldParserConfiguration_ParserStrategy_RegExHeader_Help { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_RegExHeader_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_Script

		public static string MessageFieldParserConfiguration_ParserStrategy_Script { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_Script"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_Select

		public static string MessageFieldParserConfiguration_ParserStrategy_Select { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_Select"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_Substring

		public static string MessageFieldParserConfiguration_ParserStrategy_Substring { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_Substring"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ParserStrategy_XMLProperty

		public static string MessageFieldParserConfiguration_ParserStrategy_XMLProperty { get { return GetResourceString("MessageFieldParserConfiguration_ParserStrategy_XMLProperty"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_QuotedText

		public static string MessageFieldParserConfiguration_QuotedText { get { return GetResourceString("MessageFieldParserConfiguration_QuotedText"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_QuotedText_Help

		public static string MessageFieldParserConfiguration_QuotedText_Help { get { return GetResourceString("MessageFieldParserConfiguration_QuotedText_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_RegExGroupName

		public static string MessageFieldParserConfiguration_RegExGroupName { get { return GetResourceString("MessageFieldParserConfiguration_RegExGroupName"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_RegExGroupName_Help

		public static string MessageFieldParserConfiguration_RegExGroupName_Help { get { return GetResourceString("MessageFieldParserConfiguration_RegExGroupName_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_RegExLocator

		public static string MessageFieldParserConfiguration_RegExLocator { get { return GetResourceString("MessageFieldParserConfiguration_RegExLocator"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_RegExLocator_Help

		public static string MessageFieldParserConfiguration_RegExLocator_Help { get { return GetResourceString("MessageFieldParserConfiguration_RegExLocator_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_RegExValidation

		public static string MessageFieldParserConfiguration_RegExValidation { get { return GetResourceString("MessageFieldParserConfiguration_RegExValidation"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_RegExValidation_Help

		public static string MessageFieldParserConfiguration_RegExValidation_Help { get { return GetResourceString("MessageFieldParserConfiguration_RegExValidation_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_StartIndex

		public static string MessageFieldParserConfiguration_StartIndex { get { return GetResourceString("MessageFieldParserConfiguration_StartIndex"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_StringParser_NumberBytes

		public static string MessageFieldParserConfiguration_StringParser_NumberBytes { get { return GetResourceString("MessageFieldParserConfiguration_StringParser_NumberBytes"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_StringParser_NumberBytes_Help

		public static string MessageFieldParserConfiguration_StringParser_NumberBytes_Help { get { return GetResourceString("MessageFieldParserConfiguration_StringParser_NumberBytes_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_StringParserType

		public static string MessageFieldParserConfiguration_StringParserType { get { return GetResourceString("MessageFieldParserConfiguration_StringParserType"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_StringParserType_Help

		public static string MessageFieldParserConfiguration_StringParserType_Help { get { return GetResourceString("MessageFieldParserConfiguration_StringParserType_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_StringParserType_LeadingLength

		public static string MessageFieldParserConfiguration_StringParserType_LeadingLength { get { return GetResourceString("MessageFieldParserConfiguration_StringParserType_LeadingLength"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_StringParserType_NullTerminated

		public static string MessageFieldParserConfiguration_StringParserType_NullTerminated { get { return GetResourceString("MessageFieldParserConfiguration_StringParserType_NullTerminated"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_StringParserType_Select

		public static string MessageFieldParserConfiguration_StringParserType_Select { get { return GetResourceString("MessageFieldParserConfiguration_StringParserType_Select"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_SubString_Help

		public static string MessageFieldParserConfiguration_SubString_Help { get { return GetResourceString("MessageFieldParserConfiguration_SubString_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_Title

		public static string MessageFieldParserConfiguration_Title { get { return GetResourceString("MessageFieldParserConfiguration_Title"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ValueName

		public static string MessageFieldParserConfiguration_ValueName { get { return GetResourceString("MessageFieldParserConfiguration_ValueName"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_ValueName_Help

		public static string MessageFieldParserConfiguration_ValueName_Help { get { return GetResourceString("MessageFieldParserConfiguration_ValueName_Help"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_XPath

		public static string MessageFieldParserConfiguration_XPath { get { return GetResourceString("MessageFieldParserConfiguration_XPath"); } }
//Resources:PipelineAdminResources:MessageFieldParserConfiguration_XPath_Help

		public static string MessageFieldParserConfiguration_XPath_Help { get { return GetResourceString("MessageFieldParserConfiguration_XPath_Help"); } }
//Resources:PipelineAdminResources:OutputTranslator_Description

		public static string OutputTranslator_Description { get { return GetResourceString("OutputTranslator_Description"); } }
//Resources:PipelineAdminResources:OutputTranslator_Help

		public static string OutputTranslator_Help { get { return GetResourceString("OutputTranslator_Help"); } }
//Resources:PipelineAdminResources:OutputTranslator_Title

		public static string OutputTranslator_Title { get { return GetResourceString("OutputTranslator_Title"); } }
//Resources:PipelineAdminResources:OutputTranslator_TranslatorType

		public static string OutputTranslator_TranslatorType { get { return GetResourceString("OutputTranslator_TranslatorType"); } }
//Resources:PipelineAdminResources:OutputTranslator_TranslatorType_Select

		public static string OutputTranslator_TranslatorType_Select { get { return GetResourceString("OutputTranslator_TranslatorType_Select"); } }
//Resources:PipelineAdminResources:Planner_Description

		public static string Planner_Description { get { return GetResourceString("Planner_Description"); } }
//Resources:PipelineAdminResources:Planner_DeviceIDParsers

		public static string Planner_DeviceIDParsers { get { return GetResourceString("Planner_DeviceIDParsers"); } }
//Resources:PipelineAdminResources:Planner_DeviceIDParsers_Help

		public static string Planner_DeviceIDParsers_Help { get { return GetResourceString("Planner_DeviceIDParsers_Help"); } }
//Resources:PipelineAdminResources:Planner_Help

		public static string Planner_Help { get { return GetResourceString("Planner_Help"); } }
//Resources:PipelineAdminResources:Planner_MessageTypeIDParsers

		public static string Planner_MessageTypeIDParsers { get { return GetResourceString("Planner_MessageTypeIDParsers"); } }
//Resources:PipelineAdminResources:Planner_MessageTypeIDParsers_Help

		public static string Planner_MessageTypeIDParsers_Help { get { return GetResourceString("Planner_MessageTypeIDParsers_Help"); } }
//Resources:PipelineAdminResources:Planner_PipelineModules

		public static string Planner_PipelineModules { get { return GetResourceString("Planner_PipelineModules"); } }
//Resources:PipelineAdminResources:Planner_Title

		public static string Planner_Title { get { return GetResourceString("Planner_Title"); } }
//Resources:PipelineAdminResources:Sentinel_Description

		public static string Sentinel_Description { get { return GetResourceString("Sentinel_Description"); } }
//Resources:PipelineAdminResources:Sentinel_Help

		public static string Sentinel_Help { get { return GetResourceString("Sentinel_Help"); } }
//Resources:PipelineAdminResources:Sentinel_Title

		public static string Sentinel_Title { get { return GetResourceString("Sentinel_Title"); } }
//Resources:PipelineAdminResources:Translator_Type_Binary

		public static string Translator_Type_Binary { get { return GetResourceString("Translator_Type_Binary"); } }
//Resources:PipelineAdminResources:Translator_Type_Custom

		public static string Translator_Type_Custom { get { return GetResourceString("Translator_Type_Custom"); } }
//Resources:PipelineAdminResources:Translator_Type_Delimited

		public static string Translator_Type_Delimited { get { return GetResourceString("Translator_Type_Delimited"); } }
//Resources:PipelineAdminResources:Translator_Type_JSON

		public static string Translator_Type_JSON { get { return GetResourceString("Translator_Type_JSON"); } }
//Resources:PipelineAdminResources:Translator_Type_String

		public static string Translator_Type_String { get { return GetResourceString("Translator_Type_String"); } }
//Resources:PipelineAdminResources:Translator_Type_XML

		public static string Translator_Type_XML { get { return GetResourceString("Translator_Type_XML"); } }
//Resources:PipelineAdminResources:Transmitter_Description

		public static string Transmitter_Description { get { return GetResourceString("Transmitter_Description"); } }
//Resources:PipelineAdminResources:Transmitter_Help

		public static string Transmitter_Help { get { return GetResourceString("Transmitter_Help"); } }
//Resources:PipelineAdminResources:Transmitter_Title

		public static string Transmitter_Title { get { return GetResourceString("Transmitter_Title"); } }
//Resources:PipelineAdminResources:Transmitter_TransmitterType

		public static string Transmitter_TransmitterType { get { return GetResourceString("Transmitter_TransmitterType"); } }
//Resources:PipelineAdminResources:Transmitter_TransmitterType_OriginalListener

		public static string Transmitter_TransmitterType_OriginalListener { get { return GetResourceString("Transmitter_TransmitterType_OriginalListener"); } }
//Resources:PipelineAdminResources:Transmitter_TransmitterType_Outbox

		public static string Transmitter_TransmitterType_Outbox { get { return GetResourceString("Transmitter_TransmitterType_Outbox"); } }
//Resources:PipelineAdminResources:Transmitter_TransmitterType_SMS

		public static string Transmitter_TransmitterType_SMS { get { return GetResourceString("Transmitter_TransmitterType_SMS"); } }
//Resources:PipelineAdminResources:Transmitter_TransmitterType_SMTP

		public static string Transmitter_TransmitterType_SMTP { get { return GetResourceString("Transmitter_TransmitterType_SMTP"); } }

		public static class Names
		{
			public const string Common_Description = "Common_Description";
			public const string Common_IsPublic = "Common_IsPublic";
			public const string Common_Key = "Common_Key";
			public const string Common_Key_Help = "Common_Key_Help";
			public const string Common_Key_Validation = "Common_Key_Validation";
			public const string Common_Name = "Common_Name";
			public const string Common_Notes = "Common_Notes";
			public const string Common_Script = "Common_Script";
			public const string Connection_Select_Type = "Connection_Select_Type";
			public const string Connection_Type_AMQP = "Connection_Type_AMQP";
			public const string Connection_Type_AzureEventHub = "Connection_Type_AzureEventHub";
			public const string Connection_Type_AzureIoTHub = "Connection_Type_AzureIoTHub";
			public const string Connection_Type_AzureServiceBus = "Connection_Type_AzureServiceBus";
			public const string Connection_Type_Custom = "Connection_Type_Custom";
			public const string Connection_Type_MQTT = "Connection_Type_MQTT";
			public const string Connection_Type_POP3Server = "Connection_Type_POP3Server";
			public const string Connection_Type_Rest = "Connection_Type_Rest";
			public const string Connection_Type_Soap = "Connection_Type_Soap";
			public const string Connection_Type_TCP = "Connection_Type_TCP";
			public const string Connection_Type_UDP = "Connection_Type_UDP";
			public const string CustomModule_Description = "CustomModule_Description";
			public const string CustomModule_Help = "CustomModule_Help";
			public const string CustomModule_Title = "CustomModule_Title";
			public const string InputTranslator_DelimiterSquence_Help = "InputTranslator_DelimiterSquence_Help";
			public const string InputTranslator_DelimterSequence = "InputTranslator_DelimterSequence";
			public const string InputTranslator_Description = "InputTranslator_Description";
			public const string InputTranslator_Help = "InputTranslator_Help";
			public const string InputTranslator_Title = "InputTranslator_Title";
			public const string InputTranslator_TranslatorType = "InputTranslator_TranslatorType";
			public const string InputTranslator_TranslatorType_Select = "InputTranslator_TranslatorType_Select";
			public const string Listener_Description = "Listener_Description";
			public const string Listener_EndMessageSequence = "Listener_EndMessageSequence";
			public const string Listener_EndMessageSequence_Help = "Listener_EndMessageSequence_Help";
			public const string Listener_Endpoint = "Listener_Endpoint";
			public const string Listener_Help = "Listener_Help";
			public const string Listener_KeepAliveToSendReply = "Listener_KeepAliveToSendReply";
			public const string Listener_KeepAliveToSendReplyTimeout = "Listener_KeepAliveToSendReplyTimeout";
			public const string Listener_ListenerType = "Listener_ListenerType";
			public const string Listener_MaxMessageSize = "Listener_MaxMessageSize";
			public const string Listener_MaxMessageSize_Help = "Listener_MaxMessageSize_Help";
			public const string Listener_MessageReceivedTimeout = "Listener_MessageReceivedTimeout";
			public const string Listener_MessageReceivedTimeout_Help = "Listener_MessageReceivedTimeout_Help";
			public const string Listener_Port = "Listener_Port";
			public const string Listener_Port_Help = "Listener_Port_Help";
			public const string Listener_StartMessageSequence = "Listener_StartMessageSequence";
			public const string Listener_StartMessageSequence_Help = "Listener_StartMessageSequence_Help";
			public const string Listener_Title = "Listener_Title";
			public const string MessageFieldParserConfiguration_BinaryType = "MessageFieldParserConfiguration_BinaryType";
			public const string MessageFieldParserConfiguration_BinaryType_Boolean = "MessageFieldParserConfiguration_BinaryType_Boolean";
			public const string MessageFieldParserConfiguration_BinaryType_Char = "MessageFieldParserConfiguration_BinaryType_Char";
			public const string MessageFieldParserConfiguration_BinaryType_DoublePrecisionFloatingPoint = "MessageFieldParserConfiguration_BinaryType_DoublePrecisionFloatingPoint";
			public const string MessageFieldParserConfiguration_BinaryType_Int16BigEndian = "MessageFieldParserConfiguration_BinaryType_Int16BigEndian";
			public const string MessageFieldParserConfiguration_BinaryType_Int16LittleEndian = "MessageFieldParserConfiguration_BinaryType_Int16LittleEndian";
			public const string MessageFieldParserConfiguration_BinaryType_Int32BigEndian = "MessageFieldParserConfiguration_BinaryType_Int32BigEndian";
			public const string MessageFieldParserConfiguration_BinaryType_Int32LittleEndian = "MessageFieldParserConfiguration_BinaryType_Int32LittleEndian";
			public const string MessageFieldParserConfiguration_BinaryType_Int64BigEndian = "MessageFieldParserConfiguration_BinaryType_Int64BigEndian";
			public const string MessageFieldParserConfiguration_BinaryType_Int64LittleEndian = "MessageFieldParserConfiguration_BinaryType_Int64LittleEndian";
			public const string MessageFieldParserConfiguration_BinaryType_Int8 = "MessageFieldParserConfiguration_BinaryType_Int8";
			public const string MessageFieldParserConfiguration_BinaryType_SelectDataType = "MessageFieldParserConfiguration_BinaryType_SelectDataType";
			public const string MessageFieldParserConfiguration_BinaryType_SelectDataType_Help = "MessageFieldParserConfiguration_BinaryType_SelectDataType_Help";
			public const string MessageFieldParserConfiguration_BinaryType_SinglePrecisionFloatingPoint = "MessageFieldParserConfiguration_BinaryType_SinglePrecisionFloatingPoint";
			public const string MessageFieldParserConfiguration_BinaryType_String = "MessageFieldParserConfiguration_BinaryType_String";
			public const string MessageFieldParserConfiguration_BinaryType_UInt16BigEndian = "MessageFieldParserConfiguration_BinaryType_UInt16BigEndian";
			public const string MessageFieldParserConfiguration_BinaryType_UInt16LittleEndian = "MessageFieldParserConfiguration_BinaryType_UInt16LittleEndian";
			public const string MessageFieldParserConfiguration_BinaryType_UInt32BigEndian = "MessageFieldParserConfiguration_BinaryType_UInt32BigEndian";
			public const string MessageFieldParserConfiguration_BinaryType_UInt32LittleEndian = "MessageFieldParserConfiguration_BinaryType_UInt32LittleEndian";
			public const string MessageFieldParserConfiguration_BinaryType_UInt64BigEndian = "MessageFieldParserConfiguration_BinaryType_UInt64BigEndian";
			public const string MessageFieldParserConfiguration_BinaryType_UInt64LittleEndian = "MessageFieldParserConfiguration_BinaryType_UInt64LittleEndian";
			public const string MessageFieldParserConfiguration_BinaryType_UInt8 = "MessageFieldParserConfiguration_BinaryType_UInt8";
			public const string MessageFieldParserConfiguration_DelimitedColumnIndex = "MessageFieldParserConfiguration_DelimitedColumnIndex";
			public const string MessageFieldParserConfiguration_DelimitedColumnIndex_Help = "MessageFieldParserConfiguration_DelimitedColumnIndex_Help";
			public const string MessageFieldParserConfiguration_Delimiter = "MessageFieldParserConfiguration_Delimiter";
			public const string MessageFieldParserConfiguration_Delimitor_Help = "MessageFieldParserConfiguration_Delimitor_Help";
			public const string MessageFieldParserConfiguration_Description = "MessageFieldParserConfiguration_Description";
			public const string MessageFieldParserConfiguration_Help = "MessageFieldParserConfiguration_Help";
			public const string MessageFieldParserConfiguration_KeyName = "MessageFieldParserConfiguration_KeyName";
			public const string MessageFieldParserConfiguration_KeyName_Help = "MessageFieldParserConfiguration_KeyName_Help";
			public const string MessageFieldParserConfiguration_Length = "MessageFieldParserConfiguration_Length";
			public const string MessageFieldParserConfiguration_OutputType = "MessageFieldParserConfiguration_OutputType";
			public const string MessageFieldParserConfiguration_OutputType_Boolean = "MessageFieldParserConfiguration_OutputType_Boolean";
			public const string MessageFieldParserConfiguration_OutputType_FloatingPoint = "MessageFieldParserConfiguration_OutputType_FloatingPoint";
			public const string MessageFieldParserConfiguration_OutputType_Integer = "MessageFieldParserConfiguration_OutputType_Integer";
			public const string MessageFieldParserConfiguration_OutputType_SelectDataType = "MessageFieldParserConfiguration_OutputType_SelectDataType";
			public const string MessageFieldParserConfiguration_OutputType_SelectDataType_Help = "MessageFieldParserConfiguration_OutputType_SelectDataType_Help";
			public const string MessageFieldParserConfiguration_OutputType_String = "MessageFieldParserConfiguration_OutputType_String";
			public const string MessageFieldParserConfiguration_ParserStrategy = "MessageFieldParserConfiguration_ParserStrategy";
			public const string MessageFieldParserConfiguration_ParserStrategy_Delimited = "MessageFieldParserConfiguration_ParserStrategy_Delimited";
			public const string MessageFieldParserConfiguration_ParserStrategy_Header = "MessageFieldParserConfiguration_ParserStrategy_Header";
			public const string MessageFieldParserConfiguration_ParserStrategy_Help = "MessageFieldParserConfiguration_ParserStrategy_Help";
			public const string MessageFieldParserConfiguration_ParserStrategy_JsonProperty = "MessageFieldParserConfiguration_ParserStrategy_JsonProperty";
			public const string MessageFieldParserConfiguration_ParserStrategy_Position = "MessageFieldParserConfiguration_ParserStrategy_Position";
			public const string MessageFieldParserConfiguration_ParserStrategy_RegEx = "MessageFieldParserConfiguration_ParserStrategy_RegEx";
			public const string MessageFieldParserConfiguration_ParserStrategy_RegExHeader = "MessageFieldParserConfiguration_ParserStrategy_RegExHeader";
			public const string MessageFieldParserConfiguration_ParserStrategy_RegExHeader_Help = "MessageFieldParserConfiguration_ParserStrategy_RegExHeader_Help";
			public const string MessageFieldParserConfiguration_ParserStrategy_Script = "MessageFieldParserConfiguration_ParserStrategy_Script";
			public const string MessageFieldParserConfiguration_ParserStrategy_Select = "MessageFieldParserConfiguration_ParserStrategy_Select";
			public const string MessageFieldParserConfiguration_ParserStrategy_Substring = "MessageFieldParserConfiguration_ParserStrategy_Substring";
			public const string MessageFieldParserConfiguration_ParserStrategy_XMLProperty = "MessageFieldParserConfiguration_ParserStrategy_XMLProperty";
			public const string MessageFieldParserConfiguration_QuotedText = "MessageFieldParserConfiguration_QuotedText";
			public const string MessageFieldParserConfiguration_QuotedText_Help = "MessageFieldParserConfiguration_QuotedText_Help";
			public const string MessageFieldParserConfiguration_RegExGroupName = "MessageFieldParserConfiguration_RegExGroupName";
			public const string MessageFieldParserConfiguration_RegExGroupName_Help = "MessageFieldParserConfiguration_RegExGroupName_Help";
			public const string MessageFieldParserConfiguration_RegExLocator = "MessageFieldParserConfiguration_RegExLocator";
			public const string MessageFieldParserConfiguration_RegExLocator_Help = "MessageFieldParserConfiguration_RegExLocator_Help";
			public const string MessageFieldParserConfiguration_RegExValidation = "MessageFieldParserConfiguration_RegExValidation";
			public const string MessageFieldParserConfiguration_RegExValidation_Help = "MessageFieldParserConfiguration_RegExValidation_Help";
			public const string MessageFieldParserConfiguration_StartIndex = "MessageFieldParserConfiguration_StartIndex";
			public const string MessageFieldParserConfiguration_StringParser_NumberBytes = "MessageFieldParserConfiguration_StringParser_NumberBytes";
			public const string MessageFieldParserConfiguration_StringParser_NumberBytes_Help = "MessageFieldParserConfiguration_StringParser_NumberBytes_Help";
			public const string MessageFieldParserConfiguration_StringParserType = "MessageFieldParserConfiguration_StringParserType";
			public const string MessageFieldParserConfiguration_StringParserType_Help = "MessageFieldParserConfiguration_StringParserType_Help";
			public const string MessageFieldParserConfiguration_StringParserType_LeadingLength = "MessageFieldParserConfiguration_StringParserType_LeadingLength";
			public const string MessageFieldParserConfiguration_StringParserType_NullTerminated = "MessageFieldParserConfiguration_StringParserType_NullTerminated";
			public const string MessageFieldParserConfiguration_StringParserType_Select = "MessageFieldParserConfiguration_StringParserType_Select";
			public const string MessageFieldParserConfiguration_SubString_Help = "MessageFieldParserConfiguration_SubString_Help";
			public const string MessageFieldParserConfiguration_Title = "MessageFieldParserConfiguration_Title";
			public const string MessageFieldParserConfiguration_ValueName = "MessageFieldParserConfiguration_ValueName";
			public const string MessageFieldParserConfiguration_ValueName_Help = "MessageFieldParserConfiguration_ValueName_Help";
			public const string MessageFieldParserConfiguration_XPath = "MessageFieldParserConfiguration_XPath";
			public const string MessageFieldParserConfiguration_XPath_Help = "MessageFieldParserConfiguration_XPath_Help";
			public const string OutputTranslator_Description = "OutputTranslator_Description";
			public const string OutputTranslator_Help = "OutputTranslator_Help";
			public const string OutputTranslator_Title = "OutputTranslator_Title";
			public const string OutputTranslator_TranslatorType = "OutputTranslator_TranslatorType";
			public const string OutputTranslator_TranslatorType_Select = "OutputTranslator_TranslatorType_Select";
			public const string Planner_Description = "Planner_Description";
			public const string Planner_DeviceIDParsers = "Planner_DeviceIDParsers";
			public const string Planner_DeviceIDParsers_Help = "Planner_DeviceIDParsers_Help";
			public const string Planner_Help = "Planner_Help";
			public const string Planner_MessageTypeIDParsers = "Planner_MessageTypeIDParsers";
			public const string Planner_MessageTypeIDParsers_Help = "Planner_MessageTypeIDParsers_Help";
			public const string Planner_PipelineModules = "Planner_PipelineModules";
			public const string Planner_Title = "Planner_Title";
			public const string Sentinel_Description = "Sentinel_Description";
			public const string Sentinel_Help = "Sentinel_Help";
			public const string Sentinel_Title = "Sentinel_Title";
			public const string Translator_Type_Binary = "Translator_Type_Binary";
			public const string Translator_Type_Custom = "Translator_Type_Custom";
			public const string Translator_Type_Delimited = "Translator_Type_Delimited";
			public const string Translator_Type_JSON = "Translator_Type_JSON";
			public const string Translator_Type_String = "Translator_Type_String";
			public const string Translator_Type_XML = "Translator_Type_XML";
			public const string Transmitter_Description = "Transmitter_Description";
			public const string Transmitter_Help = "Transmitter_Help";
			public const string Transmitter_Title = "Transmitter_Title";
			public const string Transmitter_TransmitterType = "Transmitter_TransmitterType";
			public const string Transmitter_TransmitterType_OriginalListener = "Transmitter_TransmitterType_OriginalListener";
			public const string Transmitter_TransmitterType_Outbox = "Transmitter_TransmitterType_Outbox";
			public const string Transmitter_TransmitterType_SMS = "Transmitter_TransmitterType_SMS";
			public const string Transmitter_TransmitterType_SMTP = "Transmitter_TransmitterType_SMTP";
		}
	}
}
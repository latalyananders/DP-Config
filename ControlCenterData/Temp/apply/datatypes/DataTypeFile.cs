using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using DT;
using DT.Exceptions;
using Metadata;
using DT.Utilities;
using DT.MdmMetadata.Types;
using DT.MdmMetadata.CoreEntity;
using DT.MdmMetadata.BusinessProcesses;
using DT.MdmMetadata.BusinessProcesses.Steps.Conditional;
using DT_TypeBuilder.CodeGen;
using DT_TypeBuilder;
using DT_TypeBuilder.Core;
using DT.TypeBuilding;
using DT_TypeBuilder.CodeGen.Expressions;
using Adk.Infrastructure.Log;
using Adk.Infrastructure;
using MsgPack.Serialization;
using DT.MdmServices;
using DT.ClusterConfiguration;
using DT_TypeBuilder.Core.Interfaces;
using DT_Processes.Services;
using DT.Metadata.Ontology;
using DT.NodeMessageProcessing.Archive;
using DT.Diagnostics.Log;
using DT.Diagnostics;
using DT.Diagnostics.Trace;
using DT.LogExtentions.OperativeLog;
using DT.Databank;
using System.Xml.Serialization;
using System.ServiceModel;

namespace SystemModels {

/// <summary>
/// DataTypeFile
/// </summary>
#line 1 "Структура данных DataTypeFile [ed6f4499-3f89-48c5-9c4f-5126a40ac8f0]"
public sealed class DataTypeFile : BaseClass, IDataType

{
[XmlIgnore]
public static readonly Guid TypeId = Guid.Parse("ed6f4499-3f89-48c5-9c4f-5126a40ac8f0");
[XmlIgnore]
public static readonly bool IsCategory = false;
/// <summary>
/// 	String [50]
/// </summary>
[JsonProperty(Required = Required.DisallowNull)]
[MessagePackIgnore]
public string Поле1
            {
                get => __core_Поле1;
                set
                {
                    if (value == null)
                                throw new ArgumentException("Значение переменной [Поле1] не может быть null.");
                            if(value.Length > 50)
                                throw new ArgumentException("Длина поля [Поле1] превышает допустимую длину в 50 символов.");
                            

                    __core_Поле1 = value;
                }
            }
            
[MessagePackMember(1)]
private string __core_Поле1 = string.Empty;



/// <summary>
/// 	String [50]
/// </summary>
[JsonProperty(Required = Required.DisallowNull)]
[MessagePackIgnore]
public string Поле2
            {
                get => __core_Поле2;
                set
                {
                    if (value == null)
                                throw new ArgumentException("Значение переменной [Поле2] не может быть null.");
                            if(value.Length > 50)
                                throw new ArgumentException("Длина поля [Поле2] превышает допустимую длину в 50 символов.");
                            

                    __core_Поле2 = value;
                }
            }
            
[MessagePackMember(2)]
private string __core_Поле2 = string.Empty;




public override bool IsDefault()
{
	return Поле1 == string.Empty
 && Поле2 == string.Empty
;
}

public DataTypeFile()
{
}

public DataTypeFile(JObject jObj)
{
    InitFromJson(jObj);
}


public override JObject ToJson(bool trim = false)
{
    var jObj = base.ToJson();
  if(Поле1 != null)
      jObj["Поле1"] = JToken.FromObject(Поле1);
  else
      jObj["Поле1"] = null;
  if(Поле2 != null)
      jObj["Поле2"] = JToken.FromObject(Поле2);
  else
      jObj["Поле2"] = null;
   return jObj;
}

public  DataTypeFile Clone()
{
    var clone = new DataTypeFile();
    clone.Поле1 = Поле1;
    clone.Поле2 = Поле2;
    return clone;
}

public override BaseClass DoClone()
{
    return Clone();
}

public LinkType CastToLink()
{
    var link = new LinkType();
    link.DataTypeId = Guid.Parse("ed6f4499-3f89-48c5-9c4f-5126a40ac8f0");
    return link;
}

public Entity ToEntity()
{
    var entity = new Entity();
    entity.Content = ToJson();
    entity.TableId = GetTypeId();
    entity.DataTypeId = GetTypeId();
    return entity;
}

public Guid GetEntityId()
{
    throw new ArgumentException("Тип данных не является объектом.");
}

public Guid GetTypeId()
{
    return TypeId;
}

public DateTime GetCreated()
{
    throw new ArgumentException("Тип данных не является объектом.");
}

public DateTime GetUpdated()
{
    throw new ArgumentException("Тип данных не является объектом.");
}

public Guid GetVersion()
{
    throw new ArgumentException("Тип данных не является объектом.");
}

public Message CastToMessage()
{
    var message = new Message();
    message.Id = Guid.NewGuid().ToString();
    message.CreationDate = DateTime.Now;
    message.SetDataTypeId(Guid.Parse("ed6f4499-3f89-48c5-9c4f-5126a40ac8f0"));
    message.SetBody(this);
    return message;
}

        public string GetDescription()
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(Поле1))
                sb.Append($"{Поле1.ToString()} ");

            var result = sb.ToString().TrimEnd();

            return result;
        }

        public string GetFullDescription()
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(Поле1))
                sb.Append($"{Поле1.ToString()} ");

            var result = sb.ToString().TrimEnd();

            return result;
        }

        public string GetFieldStrValue(string fieldName)
        {
            if ("Поле1" == fieldName)
                return Поле1 == null ? "" : $"{Поле1.ToString()}";

            if ("Поле2" == fieldName)
                return Поле2 == null ? "" : $"{Поле2.ToString()}";

            throw new InvalidOperationException($"Свойство с именем {fieldName} не найдено.");
        }

        public bool HasField(string fieldName)
        {
            if ("Поле1" == fieldName)
                return true;

            if ("Поле2" == fieldName)
                return true;

            return false;
        }

public OwnDictionary<string,object> CastToDictionary()
{
    var clone = Clone();
    var dict = new OwnDictionary<string,object>("");
    dict.Add(nameof(Поле1), clone.Поле1);
    dict.Add(nameof(Поле2), clone.Поле2);
    return dict;
}

public InternalMessage CreateMessage()
{
   var message = new InternalMessage();
   message.DataType = TypeId;
   message.Body = Encoding.UTF8.GetBytes(ToJson().ToString(Newtonsoft.Json.Formatting.None));
   return message;
}

public override bool Equals(object other)
{
   if (!(other is DataTypeFile typed))
   {
       return false;
   }
if (!base.Equals(typed))
{
    return false;
}
   return
       SystemModels.EqualsHelper.Equals(Поле1, typed.Поле1) && 
       SystemModels.EqualsHelper.Equals(Поле2, typed.Поле2);
}

public void InitFromMessage(Message message)
{
    var body = message.GetBodyAsObject();
    InitFromJson(body);
}

public void InitFromDictionary(OwnDictionary<string,object> dict)
{
object dictValue;
if (dict.TryGetValue("Поле1", out dictValue) && (dictValue is String Поле1Typed)) {
    Поле1 = Поле1Typed;
}
if (dict.TryGetValue("Поле2", out dictValue) && (dictValue is String Поле2Typed)) {
    Поле2 = Поле2Typed;
}
}

public override void InitFromJson(JObject jObj)
{
    if (BaseClassUtils.TryFillPropertyFromJObject<String>("Поле1", jObj, out var __core_Поле1_))
    {
        Поле1 = __core_Поле1_;
    }
    if (BaseClassUtils.TryFillPropertyFromJObject<String>("Поле2", jObj, out var __core_Поле2_))
    {
        Поле2 = __core_Поле2_;
    }
}

public override void AssignFromJson(JObject jObj)
{
    if (BaseClassUtils.TryFillPropertyFromJObject<String>("Поле1", jObj, out var __core_Поле1_))
    {
        this.Поле1 = __core_Поле1_;
    }
    if (BaseClassUtils.TryFillPropertyFromJObject<String>("Поле2", jObj, out var __core_Поле2_))
    {
        this.Поле2 = __core_Поле2_;
    }
}

        public bool Check(out CheckResult checkResult)
        {
            checkResult = new CheckResult();

            try
            {
            	RequiredFieldsExists();
            }
            catch (Exception ex)
            {
                checkResult.Add("Проверка заполнения полей", ex.Message);
            }

            if (checkResult.Count > 0)
            {
                return false;
            }

            return true;
        }
public void RequiredFieldsExists()
{
var dateTimeEthalon_3af0441c = DateTime.SpecifyKind(new DateTime(1900, 1, 1), DateTimeKind.Utc);
var emptySet = new HashSet<string>();
	if(emptySet.Count > 0)
		throw new Exception("Не указаны значения для обязательных полей:" + string.Join(",", emptySet));
}



}

#line default
}


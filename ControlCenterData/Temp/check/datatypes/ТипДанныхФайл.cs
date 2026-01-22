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
/// ТипДанныхФайл
/// </summary>
#line 1 "Структура данных ТипДанныхФайл [515aa5c6-e6a8-4319-83c9-c06d5bbf30a6]"
public sealed class ТипДанныхФайл : BaseClass, IDataType

{
[XmlIgnore]
public static readonly Guid TypeId = Guid.Parse("515aa5c6-e6a8-4319-83c9-c06d5bbf30a6");
[XmlIgnore]
public static readonly bool IsCategory = false;
/// <summary>
/// 	String [50]
/// </summary>
[JsonProperty(Required = Required.DisallowNull)]
[MessagePackIgnore]
public string testField1
            {
                get => __core_testField1;
                set
                {
                    if (value == null)
                                throw new ArgumentException("Значение переменной [testField1] не может быть null.");
                            if(value.Length > 50)
                                throw new ArgumentException("Длина поля [testField1] превышает допустимую длину в 50 символов.");
                            

                    __core_testField1 = value;
                }
            }
            
[MessagePackMember(1)]
private string __core_testField1 = string.Empty;



/// <summary>
/// 	String [50]
/// </summary>
[JsonProperty(Required = Required.DisallowNull)]
[MessagePackIgnore]
public string testField2
            {
                get => __core_testField2;
                set
                {
                    if (value == null)
                                throw new ArgumentException("Значение переменной [testField2] не может быть null.");
                            if(value.Length > 50)
                                throw new ArgumentException("Длина поля [testField2] превышает допустимую длину в 50 символов.");
                            

                    __core_testField2 = value;
                }
            }
            
[MessagePackMember(2)]
private string __core_testField2 = string.Empty;




public override bool IsDefault()
{
	return testField1 == string.Empty
 && testField2 == string.Empty
;
}

public ТипДанныхФайл()
{
}

public ТипДанныхФайл(JObject jObj)
{
    InitFromJson(jObj);
}


public override JObject ToJson(bool trim = false)
{
    var jObj = base.ToJson();
  if(testField1 != null)
      jObj["testField1"] = JToken.FromObject(testField1);
  else
      jObj["testField1"] = null;
  if(testField2 != null)
      jObj["testField2"] = JToken.FromObject(testField2);
  else
      jObj["testField2"] = null;
   return jObj;
}

public  ТипДанныхФайл Clone()
{
    var clone = new ТипДанныхФайл();
    clone.testField1 = testField1;
    clone.testField2 = testField2;
    return clone;
}

public override BaseClass DoClone()
{
    return Clone();
}

public LinkType CastToLink()
{
    var link = new LinkType();
    link.DataTypeId = Guid.Parse("515aa5c6-e6a8-4319-83c9-c06d5bbf30a6");
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
    message.SetDataTypeId(Guid.Parse("515aa5c6-e6a8-4319-83c9-c06d5bbf30a6"));
    message.SetBody(this);
    return message;
}

        public string GetDescription()
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(testField1))
                sb.Append($"{testField1.ToString()} ");

            var result = sb.ToString().TrimEnd();

            return result;
        }

        public string GetFullDescription()
        {
            var sb = new StringBuilder();
            if (!string.IsNullOrWhiteSpace(testField1))
                sb.Append($"{testField1.ToString()} ");

            var result = sb.ToString().TrimEnd();

            return result;
        }

        public string GetFieldStrValue(string fieldName)
        {
            if ("testField1" == fieldName)
                return testField1 == null ? "" : $"{testField1.ToString()}";

            if ("testField2" == fieldName)
                return testField2 == null ? "" : $"{testField2.ToString()}";

            throw new InvalidOperationException($"Свойство с именем {fieldName} не найдено.");
        }

        public bool HasField(string fieldName)
        {
            if ("testField1" == fieldName)
                return true;

            if ("testField2" == fieldName)
                return true;

            return false;
        }

public OwnDictionary<string,object> CastToDictionary()
{
    var clone = Clone();
    var dict = new OwnDictionary<string,object>("");
    dict.Add(nameof(testField1), clone.testField1);
    dict.Add(nameof(testField2), clone.testField2);
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
   if (!(other is ТипДанныхФайл typed))
   {
       return false;
   }
if (!base.Equals(typed))
{
    return false;
}
   return
       SystemModels.EqualsHelper.Equals(testField1, typed.testField1) && 
       SystemModels.EqualsHelper.Equals(testField2, typed.testField2);
}

public void InitFromMessage(Message message)
{
    var body = message.GetBodyAsObject();
    InitFromJson(body);
}

public void InitFromDictionary(OwnDictionary<string,object> dict)
{
object dictValue;
if (dict.TryGetValue("testField1", out dictValue) && (dictValue is String testField1Typed)) {
    testField1 = testField1Typed;
}
if (dict.TryGetValue("testField2", out dictValue) && (dictValue is String testField2Typed)) {
    testField2 = testField2Typed;
}
}

public override void InitFromJson(JObject jObj)
{
    if (BaseClassUtils.TryFillPropertyFromJObject<String>("testField1", jObj, out var __core_testField1_))
    {
        testField1 = __core_testField1_;
    }
    if (BaseClassUtils.TryFillPropertyFromJObject<String>("testField2", jObj, out var __core_testField2_))
    {
        testField2 = __core_testField2_;
    }
}

public override void AssignFromJson(JObject jObj)
{
    if (BaseClassUtils.TryFillPropertyFromJObject<String>("testField1", jObj, out var __core_testField1_))
    {
        this.testField1 = __core_testField1_;
    }
    if (BaseClassUtils.TryFillPropertyFromJObject<String>("testField2", jObj, out var __core_testField2_))
    {
        this.testField2 = __core_testField2_;
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
var dateTimeEthalon_2769350e = DateTime.SpecifyKind(new DateTime(1900, 1, 1), DateTimeKind.Utc);
var emptySet = new HashSet<string>();
	if(emptySet.Count > 0)
		throw new Exception("Не указаны значения для обязательных полей:" + string.Join(",", emptySet));
}



}

#line default
}


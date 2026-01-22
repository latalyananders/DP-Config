 using Microsoft.AspNetCore.Mvc;
                using Microsoft.AspNetCore.Authorization;
                using System;
                using System.Diagnostics;
                using System.Linq;
                using System.Text;
                using System.Collections;
                using System.Collections.Generic;
                using System.Threading.Tasks;
                
                using Adk.Net2.Protocol;
                using Newtonsoft.Json;
                using Newtonsoft.Json.Linq;
                using Newtonsoft.Json.Serialization;
                using DT;
                using DT.Utilities;
                using DT.MdmMetadata.Types;
                using DT.MdmMetadata.CoreEntity;
                using DT.MdmMetadata.BusinessProcesses;
                using DT.MdmMetadata.BusinessProcesses.Steps.Conditional;
                using DT_TypeBuilder.CodeGen;
                using DT_TypeBuilder;
                using DT.TypeBuilding;
                using DT_TypeBuilder.CodeGen.Expressions;
                using Adk.Infrastructure.Log;
                using Adk.Infrastructure;
		        using MsgPack.Serialization;
                using DT.ClusterConfiguration;
                using System.ServiceModel;
                using System.Xml.Serialization;

namespace SystemModels {

public class PlatformToFile : BaseHandlerFileOut  {

/// <summary>
/// 	String [256]Путь к файлу, Nullable
/// </summary>
[JsonProperty]
[MessagePackIgnore]
public string fileName
            {
                get => __core_fileName;
                set
                {
                    if(value?.Length > 256)
                        throw new ArgumentException("Длина поля [fileName] превышает допустимую длину в 256 символов.");
                            

                    __core_fileName = value;
                }
            }
            
[MessagePackMember(0)]
private string __core_fileName = default;



/// <summary>
/// 	String [Max]Шаблон имени файла, Nullable
/// </summary>
[JsonProperty]
[MessagePackIgnore]
public string fileNamePattern
            {
                get => __core_fileNamePattern;
                set
                {
                    

                    __core_fileNamePattern = value;
                }
            }
            
[MessagePackMember(1)]
private string __core_fileNamePattern = default;



/// <summary>
/// 
/// </summary>
[JsonProperty]
public SystemModels.ТипДанныхФайл ТипДанныхФайл
{
get => __core_ТипДанныхФайл;
set => __core_ТипДанныхФайл = value ?? new SystemModels.ТипДанныхФайл();
}
[MessagePackMember(2)]
private SystemModels.ТипДанныхФайл __core_ТипДанныхФайл = new SystemModels.ТипДанныхФайл();



public PlatformToFile (string defaultPattern)
:base("PlatformToFile", defaultPattern)
{
}

public override void SetMessage(Message message)
{
    RunMessage = message;
if(message.HasBody())
   if (message.TryCastToDataType<SystemModels.ТипДанныхФайл>(out SystemModels.ТипДанныхФайл casted))
        ТипДанныхФайл = casted;

    message.Properties.TryGetValue("fileName", out string _fileName);
    _fileName ??= fileName;
    if(string.IsNullOrEmpty(_fileName))
    {
        message.Properties.TryGetValue("fileNamePattern", out string _fileNamePattern);
        _fileNamePattern ??= fileNamePattern;
        fileNamePattern = _fileNamePattern ?? DefaultPattern;
        var formatter = new MessageStringFormatter(fileNamePattern);
        fileName = formatter.Format(message);
    }
     else
        fileName = _fileName;

}

public override string GetFileName() => fileName;
}


}


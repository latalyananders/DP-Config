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

public static partial class SystemModel {

public sealed partial class File2File : BaseScope , IProcessScope, ISetInternalMessageStep,IGetMessageScope,IGetIntScope,IGetReceiversScope,IGetSerializedScope {
public File2File(IProcessContext context, IMetadataCache metadataCache, IProcessManager processManager, IProcessDataFactory dataFactory, IBinaryProvider binaryProvider)
: base (metadataCache, processManager, dataFactory, binaryProvider, context?.MessageProperty)
{
  __core_context = context;
}

public File2File()
{
    CreateLogger();
}

public override void InitStep(Guid stepId)
{
     SetCurrentStep(stepId);
     switch(CurrentStep.StepId.ToString())
     {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. Инициализация локальных переменных"
             case "204aec04-19c6-4aba-894c-ae562250200f":
                break;
#line default
#line 1 "Шаг [Лог, Лог]. Инициализация локальных переменных"
             case "4c63b05e-975a-477c-91d0-f925b6d52c12":
                break;
#line default
         default:
             throw new ArgumentException("Неизвестный шаг " + stepId);
     }
}
public override void FinishCurrentStep()
{
     switch(CurrentStep.StepId.ToString())
     {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. После выполнения"
             case "204aec04-19c6-4aba-894c-ae562250200f":
                break;
#line default
#line 1 "Шаг [Лог, Лог]. После выполнения"
             case "4c63b05e-975a-477c-91d0-f925b6d52c12":
                break;
#line default
         default:
             throw new ArgumentException("Неизвестный шаг " + CurrentStep.StepId);
     }
}
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



public sealed class File2File_204aec0419c64aba894cae562250200f : SendToSubscribeScope  {
public File2File_204aec0419c64aba894cae562250200f (Guid stepId): base(stepId) {}
}


public override bool TryGetLogDetails(out string logDetails, out string errorMessage)
{
     bool result = true;
     logDetails = string.Empty;
     errorMessage = null;
    try
    {
         switch(CurrentStep.StepId.ToString())
         {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. Логирование шага"
            case "204aec04-19c6-4aba-894c-ae562250200f":
            {
                File2File_204aec0419c64aba894cae562250200f local = (File2File_204aec0419c64aba894cae562250200f)CurrentStep;
                break;
            }
#line 1 "Шаг [Лог, Лог]. Логирование шага"
            case "4c63b05e-975a-477c-91d0-f925b6d52c12":
            {
                LocalScope local = (LocalScope)CurrentStep;
                break;
            }
            default:
                result = false;
                errorMessage = $"В шаге {CurrentStep} логгирование пользователем не предусмотрено";
                break;
         }
    }
    catch(Exception ex)
    {
        result = false;
        errorMessage = ex.Message;
    }
    return result;
}
}


}

}


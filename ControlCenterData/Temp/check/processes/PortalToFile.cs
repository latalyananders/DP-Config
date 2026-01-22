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

public sealed partial class PortalToFile : BaseScope , IProcessScope, ISetInternalMessageStep,IGetMessageScope,IGetIntScope,IGetReceiversScope {
public PortalToFile(IProcessContext context, IMetadataCache metadataCache, IProcessManager processManager, IProcessDataFactory dataFactory, IBinaryProvider binaryProvider)
: base (metadataCache, processManager, dataFactory, binaryProvider, context?.MessageProperty)
{
  __core_context = context;
}

public PortalToFile()
{
    CreateLogger();
}

public override void InitStep(Guid stepId)
{
     SetCurrentStep(stepId);
     switch(CurrentStep.StepId.ToString())
     {
#line 1 "Шаг [Отправка подписчику, Отправка подписчику]. Инициализация локальных переменных"
             case "336a4315-b8c0-462b-9560-3bea78022a11":
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
             case "336a4315-b8c0-462b-9560-3bea78022a11":
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
public SystemModels.DataTypeFile DataTypeFile
{
get => __core_DataTypeFile;
set => __core_DataTypeFile = value ?? new SystemModels.DataTypeFile();
}
[MessagePackMember(2)]
private SystemModels.DataTypeFile __core_DataTypeFile = new SystemModels.DataTypeFile();



public sealed class PortalToFile_336a4315b8c0462b95603bea78022a11 : SendToSubscribeScope  {
public PortalToFile_336a4315b8c0462b95603bea78022a11 (Guid stepId): base(stepId) {}
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
            case "336a4315-b8c0-462b-9560-3bea78022a11":
            {
                PortalToFile_336a4315b8c0462b95603bea78022a11 local = (PortalToFile_336a4315b8c0462b95603bea78022a11)CurrentStep;
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


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

public static  class DataBankExtensions
{
public static bool Exists(this IDataBankQuery bank, Guid entityId, Metadata.DataTypes dataType) => bank.Exists(entityId, dataType.GetId());
public static bool Exists(this IDataBankQuery bank, OwnList<Guid> entityIds, out OwnList<Guid> notExists, Metadata.DataTypes dataType, bool all = false) => bank.Exists(entityIds, out notExists, dataType.GetId(), all);
public static bool Delete(this IDataBankFacadeSet bank, Guid entityId, Metadata.DataTypes dataType, bool waitResponse = true) => bank.Delete(entityId, dataType.GetId(), waitResponse);
public static bool Delete(this IDataBankFacadeSet bank, OwnList<Guid> entitiesIds, Metadata.DataTypes dataType, bool waitResponse = true) => bank.Delete(entitiesIds, dataType.GetId(), waitResponse);
}

}


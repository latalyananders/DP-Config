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

namespace Metadata {

using SystemModels;
public class HandlerInfo
{
 public Guid Id { get; set; }
 public string Name { get; set; }
 public string Description { get; set; }
 public ConnectorType ConnectorType { get; set; }
 public PropertiesCollection Parameters { get; set; }
 public bool WaitResponse { get; set; }
 public bool WaitArray { get; set; }
 public Metadata.DataTypes WaitDataType { get; set; }
 public Metadata.SM WaitSystemDataType { get; set; }

 public HandlerInfo(
                                Guid id, 
                                string name, 
                                string description, 
                                ConnectorType connector, 
                                PropertiesCollection parameters,
                                bool waitResponse,
                                bool waitArray,
        Metadata.DataTypes waitDataType,
         Metadata.SM waitSystemDataType)
 {
       Id = id;
       Name = name;
       Description = description;
       ConnectorType = connector;
       Parameters = parameters;
       WaitResponse = waitResponse;
       WaitArray = waitArray;
       WaitDataType = waitDataType;
       WaitSystemDataType = waitSystemDataType;
 }

 public HandlerInfo() {}

public override string ToString()
{
       return JSONSerializer.SerializeFullInfoWithFormatting(this);
}

}

}


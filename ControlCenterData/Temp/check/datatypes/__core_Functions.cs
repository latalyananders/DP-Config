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

[SystemTypeEnumAttribute(SystemEnumeration.Function)]
public enum Functions
{
    Empty = 0,

    [SystemTypeAttribute("f77268d4-47ff-4890-ba80-ad37d25fd97f")]
    СозданиеИзменениеDataTypeFile,

    [SystemTypeAttribute("db74fd06-d4ae-45fe-82c3-48d290989d81")]
    PortalToFile,

    [SystemTypeAttribute("5c851b14-fceb-47a8-9b13-92268fd00df5")]
    СозданиеИзменениеТипДанныхФайл,

    [SystemTypeAttribute("2447705f-aed6-4808-b429-51d22c7c92f6")]
    File2File,

    [SystemTypeAttribute("56a47819-fc30-4455-8e1a-8a2588113acd")]
    УдалениеDataTypeFile,

    [SystemTypeAttribute("09626ac9-ac77-4dbb-82af-0af9ea37c9dc")]
    УдалениеТипДанныхФайл
}

public static  class FunctionsExtensions
{
    private static readonly ISystemTypeMap<Metadata.Functions> Map;

    static FunctionsExtensions()
    {
        Map = MetadataInfo.TypeSite.Get<Metadata.Functions>();
    }

    public static Guid GetId(this Functions type) => Map.GetTypeId(type);

    public static Functions ById(Guid id) => Map.GetValue(id);

    public static string GetName(this Functions type) => type.ToString();

    public static bool IsRouter(this Metadata.Functions function)
    {
        return function switch 
        {
         Functions.СозданиеИзменениеDataTypeFile => false,
         Functions.PortalToFile => false,
         Functions.СозданиеИзменениеТипДанныхФайл => false,
         Functions.File2File => false,
         Functions.УдалениеDataTypeFile => false,
         Functions.УдалениеТипДанныхФайл => false,
         _ => false
        };
    }

    public static DataTypes GetDataType(this Metadata.Functions function)
    {
        return function switch 
        {
         Functions.СозданиеИзменениеDataTypeFile => DataTypes.DataTypeFile,
         Functions.PortalToFile => DataTypes.DataTypeFile,
         Functions.СозданиеИзменениеТипДанныхФайл => DataTypes.ТипДанныхФайл,
         Functions.File2File => DataTypes.ТипДанныхФайл,
         Functions.УдалениеDataTypeFile => DataTypes.Empty,
         Functions.УдалениеТипДанныхФайл => DataTypes.Empty,
        };
    }
    public static Metadata.SM GetSystemDataType(this Metadata.Functions function)
    {
        return function switch 
        {
         Functions.СозданиеИзменениеDataTypeFile => SM.Empty,
         Functions.PortalToFile => SM.Empty,
         Functions.СозданиеИзменениеТипДанныхФайл => SM.Empty,
         Functions.File2File => SM.Empty,
         Functions.УдалениеDataTypeFile => SM.Empty,
         Functions.УдалениеТипДанныхФайл => SM.Empty,
        };
    }
}

}


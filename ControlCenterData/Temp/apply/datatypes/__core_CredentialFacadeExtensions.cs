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

public static  class CredentialFacadeExtensions
{
public static OwnList<Metadata.Roles> GetUserRoles(this ICredentialQuery facade, CredentialUser user, bool hierarchy = true) =>
		 new OwnList<Metadata.Roles>(facade.GetUserRoles(user.EntityId, hierarchy).Select(x=>RolesExtensions.ById(x.EntityId)));

public static OwnList<Metadata.Roles> GetUserContainsRoles(this ICredentialQuery facade, CredentialUser user, bool hierarchy = true) =>
		 new OwnList<Metadata.Roles>(facade.GetUserContainsRoles(user.EntityId, hierarchy).Select(x=>RolesExtensions.ById(x.EntityId)));

public static void AddUserRole(this ICredentialModuleFacade facade, CredentialUser user, Metadata.Roles role) =>
		 facade.AddUserRole(user, role.GetId());

public static void DeleteUserRole(this ICredentialModuleFacade facade, CredentialUser user, Metadata.Roles role) =>
		 facade.DeleteUserRole(user, role.GetId());

public static bool UserHasRole(this ICredentialQuery facade, CredentialUser user, Metadata.Roles role, bool hierarchy= true) =>
		 facade.UserHasRole(user, role.GetId(), hierarchy);

public static bool UserHasContainsRole(this ICredentialQuery facade, CredentialUser user, Metadata.Roles role, bool hierarchy= true) =>
		 facade.UserHasContainsRole(user, role.GetId(), hierarchy);

public static OwnList<Metadata.Roles> GetFolderRoles(this ICredentialQuery facade, CredentialFolder folder, bool hierarchy = true) =>
		 new OwnList<Metadata.Roles>(facade.GetFolderRoles(folder.EntityId, hierarchy).Select(x=>RolesExtensions.ById(x.EntityId)));

public static OwnList<Metadata.Roles> GetFolderContainsRoles(this ICredentialQuery facade, CredentialFolder folder, bool hierarchy = true) =>
		 new OwnList<Metadata.Roles>(facade.GetFolderContainsRoles(folder.EntityId, hierarchy).Select(x=>RolesExtensions.ById(x.EntityId)));

public static void AddFolderRole(this ICredentialModuleFacade facade, CredentialFolder folder, Metadata.Roles role) =>
		 facade.AddFolderRole(folder, role.GetId());

public static void DeleteFolderRole(this ICredentialModuleFacade facade, CredentialFolder folder, Metadata.Roles role) =>
		 facade.DeleteFolderRole(folder, role.GetId());

public static bool FolderHasRole(this ICredentialQuery facade, CredentialFolder folder, Metadata.Roles role, bool hierarchy= true) =>
		 facade.FolderHasRole(folder, role.GetId(), hierarchy);

public static bool FolderHasContainsRole(this ICredentialQuery facade, CredentialFolder folder, Metadata.Roles role, bool hierarchy= true) =>
		 facade.FolderHasContainsRole(folder, role.GetId(), hierarchy);

public static OwnList<Metadata.Roles> GetCurrentUserCurrentRoles(this ICredentialQuery facade, bool hierarchy = true) =>
		 new OwnList<Metadata.Roles>(facade.GetCurrentRolesCurrentUser(hierarchy).Select(x=>RolesExtensions.ById(x.EntityId)));

public static OwnList<Metadata.Roles> GetCurrentUserAllRoles(this ICredentialQuery facade, bool hierarchy = true) =>
		 new OwnList<Metadata.Roles>(facade.GetAllRolesCurrentUser(hierarchy).Select(x=>RolesExtensions.ById(x.EntityId)));

public static bool CurrentUserHasRole(this ICredentialQuery facade, Metadata.Roles role, bool hierarchy = true) =>
		 facade.CurrentUserHasRole(role.GetId(), hierarchy);

}

}


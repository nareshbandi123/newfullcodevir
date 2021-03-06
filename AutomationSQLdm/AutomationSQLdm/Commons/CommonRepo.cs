﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace AutomationSQLdm.Commons
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the CommonRepo element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    [RepositoryFolder("9d2c49e9-5e4f-42bf-a8cf-910a588e3639")]
    public partial class CommonRepo : RepoGenBaseFolder
    {
        static CommonRepo instance = new CommonRepo();
        CommonRepoFolders.ApplicationAppFolder _application;
        CommonRepoFolders.SQLdmDesktopClientAppFolder _sqldmdesktopclient;
        CommonRepoFolders.RepositoryConnectionDialogAppFolder _repositoryconnectiondialog;

        /// <summary>
        /// Gets the singleton class instance representing the CommonRepo element repository.
        /// </summary>
        [RepositoryFolder("9d2c49e9-5e4f-42bf-a8cf-910a588e3639")]
        public static CommonRepo Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public CommonRepo() 
            : base("CommonRepo", "/", null, 0, false, "9d2c49e9-5e4f-42bf-a8cf-910a588e3639", ".\\RepositoryImages\\CommonRepo9d2c49e9.rximgres")
        {
            _application = new CommonRepoFolders.ApplicationAppFolder(this);
            _sqldmdesktopclient = new CommonRepoFolders.SQLdmDesktopClientAppFolder(this);
            _repositoryconnectiondialog = new CommonRepoFolders.RepositoryConnectionDialogAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("9d2c49e9-5e4f-42bf-a8cf-910a588e3639")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The Application folder.
        /// </summary>
        [RepositoryFolder("1a73f651-c755-42fc-8b6e-622d9bbcf5f6")]
        public virtual CommonRepoFolders.ApplicationAppFolder Application
        {
            get { return _application; }
        }

        /// <summary>
        /// The SQLdmDesktopClient folder.
        /// </summary>
        [RepositoryFolder("9545f389-3161-4094-a144-bf9e8a5703bd")]
        public virtual CommonRepoFolders.SQLdmDesktopClientAppFolder SQLdmDesktopClient
        {
            get { return _sqldmdesktopclient; }
        }

        /// <summary>
        /// The RepositoryConnectionDialog folder.
        /// </summary>
        [RepositoryFolder("045423ee-b2db-4e1b-9c8a-6f1ff05a9a01")]
        public virtual CommonRepoFolders.RepositoryConnectionDialogAppFolder RepositoryConnectionDialog
        {
            get { return _repositoryconnectiondialog; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", "8.2")]
    public partial class CommonRepoFolders
    {
        /// <summary>
        /// The ApplicationAppFolder folder.
        /// </summary>
        [RepositoryFolder("1a73f651-c755-42fc-8b6e-622d9bbcf5f6")]
        public partial class ApplicationAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _allserversInfo;
            RepoItemInfo _btnstartconsoleInfo;
            RepoItemInfo _captiontextInfo;
            RepoItemInfo _fileInfo;

            /// <summary>
            /// Creates a new Application  folder.
            /// </summary>
            public ApplicationAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Application", "/form[@title~'^Idera\\ SQL\\ diagnostic\\ mana']", parentFolder, 30000, null, true, "1a73f651-c755-42fc-8b6e-622d9bbcf5f6", "")
            {
                _allserversInfo = new RepoItemInfo(this, "AllServers", ".//tree[@controlname='userViewTreeView']//treeitem[@accessiblename='All Servers']", 30000, null, "6945e911-73e0-44d3-b52f-f257cd63dbd9");
                _btnstartconsoleInfo = new RepoItemInfo(this, "btnStartConsole", "?/?/button[@controltext='Start Console']", 30000, null, "254945ef-160d-4887-83a8-834a01203c25");
                _captiontextInfo = new RepoItemInfo(this, "CaptionText", "?/?/picture[@automationid='PART_WindowIcon']/text[@automationid='CaptionText']", 30000, null, "d79840b0-5e62-4ac0-a6b0-730140cf095e");
                _fileInfo = new RepoItemInfo(this, "File", ".//list[@automationid='fileMenu']/picture[@automationid='HeaderPresenter']/text[@caption='File']", 30000, null, "0f4ec73c-5da5-467a-a21b-741d46fe8523");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("1a73f651-c755-42fc-8b6e-622d9bbcf5f6")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("1a73f651-c755-42fc-8b6e-622d9bbcf5f6")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AllServers item.
            /// </summary>
            [RepositoryItem("6945e911-73e0-44d3-b52f-f257cd63dbd9")]
            public virtual Ranorex.TreeItem AllServers
            {
                get
                {
                    return _allserversInfo.CreateAdapter<Ranorex.TreeItem>(true);
                }
            }

            /// <summary>
            /// The AllServers item info.
            /// </summary>
            [RepositoryItemInfo("6945e911-73e0-44d3-b52f-f257cd63dbd9")]
            public virtual RepoItemInfo AllServersInfo
            {
                get
                {
                    return _allserversInfo;
                }
            }

            /// <summary>
            /// The btnStartConsole item.
            /// </summary>
            [RepositoryItem("254945ef-160d-4887-83a8-834a01203c25")]
            public virtual Ranorex.Button btnStartConsole
            {
                get
                {
                    return _btnstartconsoleInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The btnStartConsole item info.
            /// </summary>
            [RepositoryItemInfo("254945ef-160d-4887-83a8-834a01203c25")]
            public virtual RepoItemInfo btnStartConsoleInfo
            {
                get
                {
                    return _btnstartconsoleInfo;
                }
            }

            /// <summary>
            /// The CaptionText item.
            /// </summary>
            [RepositoryItem("d79840b0-5e62-4ac0-a6b0-730140cf095e")]
            public virtual Ranorex.Text CaptionText
            {
                get
                {
                    return _captiontextInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The CaptionText item info.
            /// </summary>
            [RepositoryItemInfo("d79840b0-5e62-4ac0-a6b0-730140cf095e")]
            public virtual RepoItemInfo CaptionTextInfo
            {
                get
                {
                    return _captiontextInfo;
                }
            }

            /// <summary>
            /// The File item.
            /// </summary>
            [RepositoryItem("0f4ec73c-5da5-467a-a21b-741d46fe8523")]
            public virtual Ranorex.Text File
            {
                get
                {
                    return _fileInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The File item info.
            /// </summary>
            [RepositoryItemInfo("0f4ec73c-5da5-467a-a21b-741d46fe8523")]
            public virtual RepoItemInfo FileInfo
            {
                get
                {
                    return _fileInfo;
                }
            }
        }

        /// <summary>
        /// The SQLdmDesktopClientAppFolder folder.
        /// </summary>
        [RepositoryFolder("9545f389-3161-4094-a144-bf9e8a5703bd")]
        public partial class SQLdmDesktopClientAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _connecttosqldmrepositoryInfo;
            RepoItemInfo _maintenancemodeenablemenuitemInfo;
            RepoItemInfo _maintenancemodedisablemenuitemInfo;
            RepoItemInfo _maintenancemodeschedulemenuitemInfo;

            /// <summary>
            /// Creates a new SQLdmDesktopClient  folder.
            /// </summary>
            public SQLdmDesktopClientAppFolder(RepoGenBaseFolder parentFolder) :
                    base("SQLdmDesktopClient", "/contextmenu[@processname='SQLdmDesktopClient']", parentFolder, 30000, null, false, "9545f389-3161-4094-a144-bf9e8a5703bd", "")
            {
                _connecttosqldmrepositoryInfo = new RepoItemInfo(this, "ConnectToSQLDMRepository", "menuitem[@automationid='menuFileConnect']//text[@caption~'^Connect\\ to\\ SQLDM\\ Reposito']", 30000, null, "b0af1f43-8545-4ebc-87c7-28797f7524e0");
                _maintenancemodeenablemenuitemInfo = new RepoItemInfo(this, "MaintenanceModeEnableMenuItem", "menuitem[@automationid='maintenanceModeEnableButtonKey']", 30000, null, "d2c4305a-4698-46ad-84e5-a40c309c3fe6");
                _maintenancemodedisablemenuitemInfo = new RepoItemInfo(this, "MaintenanceModeDisableMenuItem", "menuitem[@automationid='maintenanceModeDisablettonKey']", 30000, null, "2f03dfc7-d8ce-4dd4-aab7-030571ed947d");
                _maintenancemodeschedulemenuitemInfo = new RepoItemInfo(this, "MaintenanceModeScheduleMenuItem", "menuitem[@automationid='maintenanceModeScheduleButtonKey']", 30000, null, "10182fd7-0261-4e59-9fd9-1dc53a646b16");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9545f389-3161-4094-a144-bf9e8a5703bd")]
            public virtual Ranorex.ContextMenu Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.ContextMenu>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9545f389-3161-4094-a144-bf9e8a5703bd")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ConnectToSQLDMRepository item.
            /// </summary>
            [RepositoryItem("b0af1f43-8545-4ebc-87c7-28797f7524e0")]
            public virtual Ranorex.Text ConnectToSQLDMRepository
            {
                get
                {
                    return _connecttosqldmrepositoryInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The ConnectToSQLDMRepository item info.
            /// </summary>
            [RepositoryItemInfo("b0af1f43-8545-4ebc-87c7-28797f7524e0")]
            public virtual RepoItemInfo ConnectToSQLDMRepositoryInfo
            {
                get
                {
                    return _connecttosqldmrepositoryInfo;
                }
            }

            /// <summary>
            /// The MaintenanceModeEnableMenuItem item.
            /// </summary>
            [RepositoryItem("d2c4305a-4698-46ad-84e5-a40c309c3fe6")]
            public virtual Ranorex.MenuItem MaintenanceModeEnableMenuItem
            {
                get
                {
                    return _maintenancemodeenablemenuitemInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MaintenanceModeEnableMenuItem item info.
            /// </summary>
            [RepositoryItemInfo("d2c4305a-4698-46ad-84e5-a40c309c3fe6")]
            public virtual RepoItemInfo MaintenanceModeEnableMenuItemInfo
            {
                get
                {
                    return _maintenancemodeenablemenuitemInfo;
                }
            }

            /// <summary>
            /// The MaintenanceModeDisableMenuItem item.
            /// </summary>
            [RepositoryItem("2f03dfc7-d8ce-4dd4-aab7-030571ed947d")]
            public virtual Ranorex.MenuItem MaintenanceModeDisableMenuItem
            {
                get
                {
                    return _maintenancemodedisablemenuitemInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MaintenanceModeDisableMenuItem item info.
            /// </summary>
            [RepositoryItemInfo("2f03dfc7-d8ce-4dd4-aab7-030571ed947d")]
            public virtual RepoItemInfo MaintenanceModeDisableMenuItemInfo
            {
                get
                {
                    return _maintenancemodedisablemenuitemInfo;
                }
            }

            /// <summary>
            /// The MaintenanceModeScheduleMenuItem item.
            /// </summary>
            [RepositoryItem("10182fd7-0261-4e59-9fd9-1dc53a646b16")]
            public virtual Ranorex.MenuItem MaintenanceModeScheduleMenuItem
            {
                get
                {
                    return _maintenancemodeschedulemenuitemInfo.CreateAdapter<Ranorex.MenuItem>(true);
                }
            }

            /// <summary>
            /// The MaintenanceModeScheduleMenuItem item info.
            /// </summary>
            [RepositoryItemInfo("10182fd7-0261-4e59-9fd9-1dc53a646b16")]
            public virtual RepoItemInfo MaintenanceModeScheduleMenuItemInfo
            {
                get
                {
                    return _maintenancemodeschedulemenuitemInfo;
                }
            }
        }

        /// <summary>
        /// The RepositoryConnectionDialogAppFolder folder.
        /// </summary>
        [RepositoryFolder("045423ee-b2db-4e1b-9c8a-6f1ff05a9a01")]
        public partial class RepositoryConnectionDialogAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _authenticationdropdownlistInfo;
            RepoItemInfo _usernameInfo;
            RepoItemInfo _passwordInfo;
            RepoItemInfo _connectbuttonInfo;

            /// <summary>
            /// Creates a new RepositoryConnectionDialog  folder.
            /// </summary>
            public RepositoryConnectionDialogAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RepositoryConnectionDialog", "/form[@controlname='RepositoryConnectionDialog']", parentFolder, 30000, null, true, "045423ee-b2db-4e1b-9c8a-6f1ff05a9a01", "")
            {
                _authenticationdropdownlistInfo = new RepoItemInfo(this, "AuthenticationDropDownList", "?/?/combobox[@controlname='authenticationDropDownList']", 30000, null, "dc9cff80-6ea0-4c96-b2c2-4485849f86c2");
                _usernameInfo = new RepoItemInfo(this, "Username", "container[@controlname='tableLayoutPanel1']/text[@controlname='userNameTextbox']/text[@accessiblerole='Text']", 30000, null, "5eeaae31-fd4d-4fbd-ac6c-515bb447de4b");
                _passwordInfo = new RepoItemInfo(this, "Password", "container[@controlname='tableLayoutPanel1']/text[@controlname='passwordTextbox']/text[@accessiblerole='Text']", 30000, null, "760aca35-edaa-457c-80e3-f1c2facc7ef0");
                _connectbuttonInfo = new RepoItemInfo(this, "ConnectButton", "button[@controlname='connectButton']", 30000, null, "e1850cb0-9ae2-477a-8e4b-4fe290ab7a5a");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("045423ee-b2db-4e1b-9c8a-6f1ff05a9a01")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("045423ee-b2db-4e1b-9c8a-6f1ff05a9a01")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The AuthenticationDropDownList item.
            /// </summary>
            [RepositoryItem("dc9cff80-6ea0-4c96-b2c2-4485849f86c2")]
            public virtual Ranorex.ComboBox AuthenticationDropDownList
            {
                get
                {
                    return _authenticationdropdownlistInfo.CreateAdapter<Ranorex.ComboBox>(true);
                }
            }

            /// <summary>
            /// The AuthenticationDropDownList item info.
            /// </summary>
            [RepositoryItemInfo("dc9cff80-6ea0-4c96-b2c2-4485849f86c2")]
            public virtual RepoItemInfo AuthenticationDropDownListInfo
            {
                get
                {
                    return _authenticationdropdownlistInfo;
                }
            }

            /// <summary>
            /// The Username item.
            /// </summary>
            [RepositoryItem("5eeaae31-fd4d-4fbd-ac6c-515bb447de4b")]
            public virtual Ranorex.Text Username
            {
                get
                {
                    return _usernameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Username item info.
            /// </summary>
            [RepositoryItemInfo("5eeaae31-fd4d-4fbd-ac6c-515bb447de4b")]
            public virtual RepoItemInfo UsernameInfo
            {
                get
                {
                    return _usernameInfo;
                }
            }

            /// <summary>
            /// The Password item.
            /// </summary>
            [RepositoryItem("760aca35-edaa-457c-80e3-f1c2facc7ef0")]
            public virtual Ranorex.Text Password
            {
                get
                {
                    return _passwordInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Password item info.
            /// </summary>
            [RepositoryItemInfo("760aca35-edaa-457c-80e3-f1c2facc7ef0")]
            public virtual RepoItemInfo PasswordInfo
            {
                get
                {
                    return _passwordInfo;
                }
            }

            /// <summary>
            /// The ConnectButton item.
            /// </summary>
            [RepositoryItem("e1850cb0-9ae2-477a-8e4b-4fe290ab7a5a")]
            public virtual Ranorex.Button ConnectButton
            {
                get
                {
                    return _connectbuttonInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ConnectButton item info.
            /// </summary>
            [RepositoryItemInfo("e1850cb0-9ae2-477a-8e4b-4fe290ab7a5a")]
            public virtual RepoItemInfo ConnectButtonInfo
            {
                get
                {
                    return _connectbuttonInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
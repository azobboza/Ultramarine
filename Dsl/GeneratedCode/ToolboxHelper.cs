﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using System;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace Ultramarine.Generators.Language
{
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	/// <remarks>
	/// Double-derived class to allow easier code customization.
	/// </remarks>
	public partial class GeneratorLanguageToolboxHelper : GeneratorLanguageToolboxHelperBase 
	{
		/// <summary>
		/// Constructs a new GeneratorLanguageToolboxHelper.
		/// </summary>
		public GeneratorLanguageToolboxHelper(global::System.IServiceProvider serviceProvider)
			: base(serviceProvider) { }
	}
	
	/// <summary>
	/// Helper class used to create and initialize toolbox items for this DSL.
	/// </summary>
	
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable", Justification = "The store is disposed on domain shut down")]
	public abstract class GeneratorLanguageToolboxHelperBase
	{
		/// <summary>
		/// Toolbox item filter string used to identify GeneratorLanguage toolbox items.  
		/// </summary>
		/// <remarks>
		/// See the MSDN documentation for the ToolboxItemFilterAttribute class for more information on toolbox
		/// item filters.
		/// </remarks>
		public const string ToolboxFilterString = "GeneratorLanguage.1.0";
		/// <summary>
		/// Toolbox item filter string used to identify ConnectedWithRelationship connector tool.
		/// </summary>
		public const string ConnectedWithRelationshipFilterString = "ConnectedWithRelationship.1.0";

	
		private global::System.Collections.Generic.Dictionary<string, DslDesign::ModelingToolboxItem> toolboxItemCache = new global::System.Collections.Generic.Dictionary<string, DslDesign::ModelingToolboxItem>();
		private DslModeling::Store toolboxStore;
		
		private global::System.IServiceProvider sp;
		
		/// <summary>
		/// Constructs a new GeneratorLanguageToolboxHelperBase.
		/// </summary>
		protected GeneratorLanguageToolboxHelperBase(global::System.IServiceProvider serviceProvider)
		{
			if(serviceProvider == null) throw new global::System.ArgumentNullException("serviceProvider");
			
			this.sp = serviceProvider;
		}
		
		/// <summary>
		/// Serivce provider used to access services from the hosting environment.
		/// </summary>
		protected global::System.IServiceProvider ServiceProvider
		{
			get
			{
				return this.sp;
			}
		}

		/// <summary>
		/// Returns the display name of the tab that should be opened by default when the editor is opened.
		/// </summary>
		public static string DefaultToolboxTabName
		{
			get
			{
				return global::Ultramarine.Generators.Language.GeneratorLanguageDomainModel.SingletonResourceManager.GetString("GeneratorLanguageToolboxTab", global::System.Globalization.CultureInfo.CurrentUICulture);
			}
		}
		
		
		/// <summary>
		/// Returns the toolbox items count in the default tool box tab.
		/// </summary>
		public static int DefaultToolboxTabToolboxItemsCount
		{
			get
			{
				return 10;
			}
		}
		

		/// <summary>
		/// Returns a list of custom toolbox items to be added dynamically
		/// </summary>
		public virtual global::System.Collections.Generic.IList<DslDesign::ModelingToolboxItem> CreateToolboxItems()
		{
			global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem> toolboxItems = new global::System.Collections.Generic.List<DslDesign::ModelingToolboxItem>();
			return toolboxItems;
		}
		
		/// <summary>
		/// Creates an ElementGroupPrototype for the element tool corresponding to the given domain class id.
		/// Default behavior is to create a prototype containing an instance of the domain class.
		/// Derived classes may override this to add additional information to the prototype.
		/// </summary>
		protected virtual DslModeling::ElementGroupPrototype CreateElementToolPrototype(DslModeling::Store store, global::System.Guid domainClassId)
		{
			DslModeling::ModelElement element = store.ElementFactory.CreateElement(domainClassId);
			DslModeling::ElementGroup elementGroup = new DslModeling::ElementGroup(store.DefaultPartition);
			elementGroup.AddGraph(element, true);
			return elementGroup.CreatePrototype();
		}

		/// <summary>
		/// Returns instance of ModelingToolboxItem based on specified name.
		/// This method must be called from within a Transaction. Failure to do so will result in an exception
		/// </summary>
		/// <param name="itemId">unique name of desired ToolboxItem</param>
		/// <param name="store">Store to perform the operation against</param>
		/// <returns>An instance of ModelingToolboxItem if the itemId can be resolved, null otherwise</returns>
		public virtual DslDesign::ModelingToolboxItem GetToolboxItem(string itemId, DslModeling::Store store)
		{
			DslDesign::ModelingToolboxItem result = null;
			if (string.IsNullOrEmpty(itemId))
			{
				return null;
			}
			if (store == null)
			{
				return null;
			}
			global::System.Resources.ResourceManager resourceManager = global::Ultramarine.Generators.Language.GeneratorLanguageDomainModel.SingletonResourceManager;
			global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;
			switch(itemId)
			{
				case "Ultramarine.Generators.Language.ConnectedWithRelationshipToolboxItem":

					// Add ConnectedWithRelationship connector tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.ConnectedWithRelationshipToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						1, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ConnectedWithRelationshipToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ConnectedWithRelationshipToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.				
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ConnectExampleRelationF1Keyword", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ConnectedWithRelationshipToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						null, // Connector toolbox items do not have an underlying data object.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require), 
							new global::System.ComponentModel.ToolboxItemFilterAttribute(ConnectedWithRelationshipFilterString)
						});
					break;
				case "Ultramarine.Generators.Language.BuildProjectToolboxItem":
					// Add BuildProject shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.BuildProjectToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						2, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("BuildProjectToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("BuildProjectToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"BuildProject", // F1 help keyword for the toolbox item.
						resourceManager.GetString("BuildProjectToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.BuildProject.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Ultramarine.Generators.Language.CreateFolderToolboxItem":
					// Add CreateFolder shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.CreateFolderToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						3, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("CreateFolderToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("CreateFolderToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"CreateFolder", // F1 help keyword for the toolbox item.
						resourceManager.GetString("CreateFolderToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.CreateFolder.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Ultramarine.Generators.Language.CreateProjectItemToolboxItem":
					// Add CreateProjectItem shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.CreateProjectItemToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						4, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("CreateProjectItemToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("CreateProjectItemToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"CreateProjectItem", // F1 help keyword for the toolbox item.
						resourceManager.GetString("CreateProjectItemToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.CreateProjectItem.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Ultramarine.Generators.Language.LoadCodeElementToolboxItem":
					// Add LoadCodeElement shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.LoadCodeElementToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						5, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("LoadCodeElementToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("LoadCodeElementToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"CreateExampleClassF1Keyword", // F1 help keyword for the toolbox item.
						resourceManager.GetString("LoadCodeElementToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.LoadCodeElement.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Ultramarine.Generators.Language.LoadProjectItemToolboxItem":
					// Add LoadProjectItem shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.LoadProjectItemToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						6, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("LoadProjectItemToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("LoadProjectItemToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"LoadProjectItem", // F1 help keyword for the toolbox item.
						resourceManager.GetString("LoadProjectItemToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.LoadProjectItem.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Ultramarine.Generators.Language.ReadPropertyToolboxItem":
					// Add ReadProperty shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.ReadPropertyToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						7, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("ReadPropertyToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("ReadPropertyToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"ReadProperty", // F1 help keyword for the toolbox item.
						resourceManager.GetString("ReadPropertyToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.ReadProperty.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Ultramarine.Generators.Language.SetVariableToolboxItem":
					// Add SetVariable shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.SetVariableToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						8, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("SetVariableToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("SetVariableToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"SetVariable", // F1 help keyword for the toolbox item.
						resourceManager.GetString("SetVariableToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.SetVariable.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Ultramarine.Generators.Language.IteratorToolboxItem":
					// Add Iterator shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.IteratorToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						9, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("IteratorToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("IteratorToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"Iterator", // F1 help keyword for the toolbox item.
						resourceManager.GetString("IteratorToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.Iterator.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				case "Ultramarine.Generators.Language.TextTransformationToolboxItem":
					// Add TextTransformation shape tool.
					result = new DslDesign::ModelingToolboxItem(
						"Ultramarine.Generators.Language.TextTransformationToolboxItem", // Unique identifier (non-localized) for the toolbox item.
						10, // Position relative to other items in the same toolbox tab.
						resourceManager.GetString("TextTransformationToolboxItem", resourceCulture), // Localized display name for the item.
						(global::System.Drawing.Bitmap)DslDiagrams::ImageHelper.GetImage(resourceManager.GetObject("TextTransformationToolboxBitmap", resourceCulture)), // Image displayed next to the toolbox item.
						"Ultramarine.Generators.Language.GeneratorLanguageToolboxTab", // Unique identifier (non-localized) for the toolbox item tab.
						resourceManager.GetString("GeneratorLanguageToolboxTab", resourceCulture), // Localized display name for the toolbox tab.
						"TextTransformation", // F1 help keyword for the toolbox item.
						resourceManager.GetString("TextTransformationToolboxTooltip", resourceCulture), // Localized tooltip text for the toolbox item.
						CreateElementToolPrototype(store, global::Ultramarine.Generators.Language.TextTransformation.DomainClassId), // ElementGroupPrototype (data object) representing model element on the toolbox.
						new global::System.ComponentModel.ToolboxItemFilterAttribute[] { // Collection of ToolboxItemFilterAttribute objects that determine visibility of the toolbox item.
						new global::System.ComponentModel.ToolboxItemFilterAttribute(ToolboxFilterString, global::System.ComponentModel.ToolboxItemFilterType.Require) 
						});
					break;
				default:
					break;
			} // end switch
			
			return result;
		}
		

		/// <summary>
		/// The store toe be used for all the toolbox item creation
		/// </summary>
		protected DslModeling::Store ToolboxStore
		{
			get
			{ 
				if (toolboxStore==null)
				{
					toolboxStore = new DslModeling::Store(this.ServiceProvider);
					EventHandler StoreCleanUp = (o, e) =>
					{
						//Since Store implements IDisposable, we need to dispose it when we're finished
						if (this.toolboxStore != null)
						{
							this.toolboxStore.Dispose();
						}
						this.toolboxStore = null;
					};
					//There is no DomainUnload event for the default AppDomain, so we listen for both ProcessExit and DomainUnload
					AppDomain.CurrentDomain.ProcessExit += new EventHandler(StoreCleanUp);
					AppDomain.CurrentDomain.DomainUnload += new EventHandler(StoreCleanUp);
					
					//load the domain model
					toolboxStore.LoadDomainModels(typeof(global::Ultramarine.Generators.Language.GeneratorLanguageDomainModel));
					
				}
				return toolboxStore;
			}
		}
		
		/// <summary>
		/// Given a toolbox item "unique ID" returns the the toolbox item using cached dictionary
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve</param>
		private DslDesign::ModelingToolboxItem GetToolboxItem(string itemId)
		{
			DslDesign::ModelingToolboxItem item = null;

			if (!this.toolboxItemCache.TryGetValue(itemId, out item))
			{
				DslModeling::Store store = this.ToolboxStore;
				
				// Open transaction so we can create model elements corresponding to toolbox items.
				using (DslModeling::Transaction t = store.TransactionManager.BeginTransaction("CreateToolboxItems"))
				{
					// Retrieve the specified ToolboxItem from the DSL
					this.toolboxItemCache[itemId] = item = this.GetToolboxItem(itemId, store);
				}
			}

			return item;
		}
		
		/// <summary>
		/// Given a toolbox item "unique ID" and a data format identifier, returns the content of
		/// the data format. 
		/// </summary>
		/// <param name="itemId">The unique ToolboxItem to retrieve data for</param>
		/// <param name="format">The desired format of the resulting data</param>
		public virtual object GetToolboxItemData(string itemId, DataFormats.Format format)
		{
			DslDesign::ModelingToolboxItem item = null;

			global::System.Resources.ResourceManager resourceManager = global::Ultramarine.Generators.Language.GeneratorLanguageDomainModel.SingletonResourceManager;
			global::System.Globalization.CultureInfo resourceCulture = global::System.Globalization.CultureInfo.CurrentUICulture;

			System.Windows.Forms.IDataObject tbxDataObj;

			//get the toolbox item
			item = GetToolboxItem(itemId);

			if (item != null)
			{
				ToolboxItemContainer container = new ToolboxItemContainer(item);
				tbxDataObj = container.ToolboxData;

				if (tbxDataObj.GetDataPresent(format.Name))
				{
					return tbxDataObj.GetData(format.Name);
				}
				else 
				{
					string invalidFormatString = resourceManager.GetString("UnsupportedToolboxFormat", resourceCulture);
					throw new InvalidOperationException(string.Format(resourceCulture, invalidFormatString, format.Name));
				}
			}

			string errorFormatString = resourceManager.GetString("UnresolvedToolboxItem", resourceCulture);
			throw new InvalidOperationException(string.Format(resourceCulture, errorFormatString, itemId));
		}		
	}
}

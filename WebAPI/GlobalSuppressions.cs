#region "CA1704:IdentifiersShouldBeSpelledCorrectly", Justification = "As per standards"
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MAQ", Justification = "As per requirment api is a term used in project henced supressed from warnings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1709:IdentifiersShouldBeCasedCorrectly", MessageId = "MAQ", Scope = "namespace", Target = "MAQ.WebService.Template", Justification = "As per requirment api is a term used in project henced supressed from warnings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Cors", Scope = "type", Target = "MAQ.WebService.Template.AllowCorsAttribute", Justification = "As per requirment api is a term used in project henced supressed from warnings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Cors", Scope = "type", Target = "MAQ.WebService.Template.CorsController", Justification = "As per requirment api is a term used in project henced supressed from warnings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Api", Scope = "type", Target = "MAQ.WebService.Template.WebApiConfig", Justification = "As per requirment api is a term used in project henced supressed from warnings")]


#endregion
#region "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Its a logger exception. Cannot do anything since logger fails to log the error message on Azure database."
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MAQ.WebService.Template.AzureLogger.#AddtoTable(System.String,System.String)", Justification = "Its a logger exception. Cannot do anything since logger fails to log the error message on Azure database.")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "MAQ.WebService.Template.ExportToExcelController.#Export()", Justification = "Its a logger exception. Cannot do anything since logger fails to log the error message on Azure database.")]

#endregion
#region "CA1822:MarkMembersAsStatic", Justification = "Need to access System.Web.HttpApplication as interface"
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "MAQ.WebService.Template.ExportToExcelController.#Export()", Justification = "Need to access System.Web.HttpApplication as interface")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "MAQ.WebService.Template.WebApiApplication.#Application_Start()", Justification = "Need to access System.Web.HttpApplication as interface")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope", Scope = "member", Target = "MAQ.WebService.Template.ExportToExcelController.#Export()", Justification = "Disposable objects")]

#endregion
// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.
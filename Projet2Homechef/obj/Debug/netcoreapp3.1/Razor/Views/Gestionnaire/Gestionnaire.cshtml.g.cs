#pragma checksum "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73ed883ed7871172baee90d2fb87cea1e6dd7c2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gestionnaire_Gestionnaire), @"mvc.1.0.view", @"/Views/Gestionnaire/Gestionnaire.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73ed883ed7871172baee90d2fb87cea1e6dd7c2a", @"/Views/Gestionnaire/Gestionnaire.cshtml")]
    #nullable restore
    public class Views_Gestionnaire_Gestionnaire : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Gestionnaire\Gestionnaire.cshtml"
  
    ViewBag.Title = "Gestionnaire";
    Layout = "_LayoutChoixSejour";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""titre"">Gestionnaire</h3>

 
<table border=""1"">
      <tr>
          <th>UserName</th>
          <th>Nom</th>    
          <th>Prenom</th>  
          <th>DateDeNaissance</th>
          <th>Email</th> 
          <th>Tel</th> 
          <th>Role</th> 
          <th>DateDeNaissance</th> 
          <th>Valider</th>
          <th>Refuser</th>
      </tr>
      
      
          <tr>
              
              <button1 class=""btn btn-success btn-xl"" type=""submit"">Valider</button1>
              <button2 class=""btn btn-danger btn-xl"" type=""submit"">Refuser</button2>
          </tr>
      
  </table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
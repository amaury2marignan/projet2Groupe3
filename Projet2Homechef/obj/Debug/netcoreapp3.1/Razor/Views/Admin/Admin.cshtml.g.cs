#pragma checksum "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e56fc07ef99435d9e70256b77fcea0172c0914"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Admin), @"mvc.1.0.view", @"/Views/Admin/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e56fc07ef99435d9e70256b77fcea0172c0914", @"/Views/Admin/Admin.cshtml")]
    #nullable restore
    public class Views_Admin_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Projet2Homechef.Models.Villageois>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
  
    ViewBag.Title = "Admin";
    Layout = "_LayoutChoixSejour";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3 class=""titre"">Gestionnaire</h3>




<table border=""1"">
      <tr>
          <th>Nom</th>    
          <th>Prenom</th>  
          <th>DateDeNaissance</th>
          <th>Email</th> 
          <th>Tel</th> 
          <th>Role</th> 
          <th> Valider </th>
          <th>Refuser</th>
          <th>Supprimer</th>
       </tr>
");
#nullable restore
#line 25 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
     foreach(var villageois in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\r\n          <td>");
#nullable restore
#line 28 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
         Write(villageois.Nom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>    \r\n          <td>");
#nullable restore
#line 29 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
         Write(villageois.Prenom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n          <td>");
#nullable restore
#line 30 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
         Write(villageois.DateDeNaissance.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n          <td>");
#nullable restore
#line 31 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
         Write(villageois.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n          <td>");
#nullable restore
#line 32 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
         Write(villageois.Tel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n          <td>");
#nullable restore
#line 33 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
         Write(villageois.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n          <td> <button1 class=\"btn btn-success btn-xl\" type=\"submit\">");
#nullable restore
#line 34 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
                                                                Write(Html.ActionLink("modifier", "FormulaireVillageois", "Admin",new{@id = @villageois.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </button1> </td>\r\n          <td> <button2 class=\"btn btn-danger btn-xl\" type=\"submit\">");
#nullable restore
#line 35 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
                                                               Write(Html.ActionLink("supprimer", "DeleteVillageois", "Admin", new{@id = @villageois.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button2> </td>\r\n         \r\n\r\n      </tr>\r\n");
#nullable restore
#line 39 "C:\Users\Amaury\Documents\DEV\PROJETS\PROJET 2\Projet2repo\projet2Groupe3\Projet2Homechef\Views\Admin\Admin.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n      \r\n  </table>\r\n  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Projet2Homechef.Models.Villageois>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

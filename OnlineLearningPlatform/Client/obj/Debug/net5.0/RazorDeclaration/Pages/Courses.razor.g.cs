// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace OnlineLearningPlatform.Client.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\_Imports.razor"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\_Imports.razor"
using Client.Layout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\Pages\Courses.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\Pages\Courses.razor"
using OnlineLearningPlatform.Client.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\Pages\Courses.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/courses")]
    public partial class Courses : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\My_Projects\Online_Learning_Platform\OnlineLearningPlatform\Client\Pages\Courses.razor"
       
    private List<CourseModel> courses;

    protected override async Task OnInitializedAsync()
    {
        await LoadCourses();
    }

    private async Task LoadCourses()
    {
        courses = await Http.GetFromJsonAsync<List<CourseModel>>("courses");
    }

    private void AddCourse()
    {
        // Navigate to Add Course Page
    }

    private void EditCourse(int id)
    {
        // Navigate to Edit Course Page
    }

    private async Task DeleteCourse(int id)
    {
        var response = await Http.DeleteAsync($"courses/{id}");
        if (response.IsSuccessStatusCode)
        {
            // Reload courses after deletion
            await LoadCourses();
        }
        else
        {
            // Handle error if deletion fails
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
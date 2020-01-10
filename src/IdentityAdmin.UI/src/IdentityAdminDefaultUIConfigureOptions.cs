using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Reflection;

namespace Wangkanai.IdentityAdmin.UI
{
    internal class IdentityAdminDefaultUIConfigureOptions<TUser>
        : IPostConfigureOptions<RazorPagesOptions> where TUser : class
    {
        private const string IdentityAdminUIDefaultAreaName = "admin";

        public IdentityAdminDefaultUIConfigureOptions(IWebHostEnvironment environment)
        {
            Environment = environment;
        }

        public IWebHostEnvironment Environment { get; }

        public void PostConfigure(string name, RazorPagesOptions options)
        {
            if (name is null)
                throw new ArgumentNullException(nameof(name));

            if (options is null)
                throw new ArgumentNullException(nameof(options));

            options.Conventions.AuthorizeAreaFolder(IdentityAdminUIDefaultAreaName, "/");
            options.Conventions.AuthorizeAreaPage(IdentityAdminUIDefaultAreaName, "/Admin");

            var convention = new IdentityAdminPageModelConvention<TUser>();
        }
    }

    internal class IdentityAdminPageModelConvention<TUser>
        : IPageApplicationModelConvention where TUser : class
    {
        public void Apply(PageApplicationModel model)
        {
            var defaultUIAttribute = model.ModelType.GetCustomAttribute<IdentityAdminDefaultUIAttribute>();
            if (defaultUIAttribute is null)
                return;

            ValidateTemplate(defaultUIAttribute.Template);
            var templateInstance = defaultUIAttribute.Template.MakeGenericType(typeof(TUser));
            model.ModelType = templateInstance.GetTypeInfo();
        }

        private void ValidateTemplate(Type template)
        {
            if (template.IsAbstract || !template.IsGenericTypeDefinition)
                throw new InvalidOperationException("Implementation type can't be abstract or non generic.");

            var genericArgments = template.GetGenericArguments();
            if (genericArgments.Length != 1)
                throw new InvalidOperationException("Implementation type contains wrong generic arity.");
        }
    }

    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    internal sealed class IdentityAdminDefaultUIAttribute : Attribute
    {
        public IdentityAdminDefaultUIAttribute(Type implementationTemplate)
        {
            Template = implementationTemplate;
        }

        public Type Template { get; }
    }
}
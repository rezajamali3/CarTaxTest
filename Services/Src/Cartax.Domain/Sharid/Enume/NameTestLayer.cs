
using System.Reflection;

using Cartax.Domain;

namespace Cartax1.Test
{
    public class NameTestLayer
    {
        public  const string DomainNamespace = "Cartax.Domain";
        public  const string ApplicationsNamespace = "Cartax.Applications";
        public  const string InfraSturcharNamespace = "Cartax.InfraSturchar";
        public  const string PresentationNamespace = "Cartax.Presentation";
        public  const string UInamespace = "Cartax.WebAPI";


        //[Fact]
        //public void Domain_Should_Not_HaveDependencyOnOtherProject()
        //{
     
        //    string namespaceName = "Your.Library.Namespace"; // نام فضای‌نام کلاس لایبری
        //    Type type = typeof(DomainNamespace); // نام کلاس لایبری
        //    Assembly assembly = Assembly.GetAssembly(type);

        //    var otherProject = new[]
        //    {
        //        ApplicationsNamespace,
        //        InfraSturcharNamespace,
        //        PresentationNamespace,
        //        UInamespace
        //    };

        //    var testResult =Types
        //        .InAssemblies(assembly)
        //        .ShouldNot()
        //        .HaveDependencyOnAll(otherProject)
        //        .GetResult();

        //    testResult.IsSuccessful.Should().BeTrue();

        //}


    }
}
using Autofac;
using Uppgift_1_CodePattern;
using Uppgift_1_CodePattern.Interfaces;
using Uppgift_1_CodePattern.Models;
using Uppgift_1_CodePattern.Models.Customers;

var container = AFConfig.Configure();

using (var scope = container.BeginLifetimeScope())
{
    
    var app = scope.Resolve<IApplication>();
    app.Run();

}

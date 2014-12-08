using Autofac;

namespace PersonalDomain.Infrastructure.IoC
{
    public abstract class AutofacContainer : IIoCContainer
    {
        private IContainer _container { get; set; }
        public virtual IContainer Container
        {
            get { return _container ?? (_container = BuildContainer()); }
        }

        private ContainerBuilder _containerBuilder { get; set; }
        public virtual ContainerBuilder ContainerBuilder
        {
            get { return _containerBuilder ?? (_containerBuilder = new ContainerBuilder()); }
        }
        protected virtual IContainer BuildContainer()
        {
            RegisterComponents();
            RegisterOperations();
            return ContainerBuilder.Build();
        }

        public abstract void RegisterComponents();
        public abstract void RegisterOperations();
    }
}

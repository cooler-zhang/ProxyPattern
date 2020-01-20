## [Proxy Pattern](https://www.dofactory.com/net/proxy-design-pattern)
- ### Definition
  - #### Provide a surrogate or placeholder for another object to control access to it.
  - ##### Proxy
     - maintains a reference that lets the proxy access the real subject. Proxy may refer to a Subject if the RealSubject and Subject interfaces are the same.
     - provides an interface identical to Subject's so that a proxy can be substituted for for the real subject.
     - controls access to the real subject and may be responsible for creating and deleting it.
     - other responsibilites depend on the kind of proxy:
      - remote proxies are responsible for encoding a request and its arguments and for sending the encoded request to the real subject in a different address space.
      - virtual proxies may cache additional information about the real subject so that they can postpone accessing it. For example, the ImageProxy from the Motivation caches the real images's extent.
        - protection proxies check that the caller has the access permissions required to perform a request.
  - ##### Subject
        defines the common interface for RealSubject and Proxy so that a Proxy can be used anywhere a RealSubject is expected.
  - ##### RealSubject
        defines the real object that the proxy represents.
- ### UML
  ![Proxy](https://www.dofactory.com/images/diagrams/net/proxy.gif)
- ### Demo
  - #### ProxyPattern.Base
- ### Proxy Apply ###
  - #### Open Source
    - [SignalR](https://github.com/SignalR/SignalR/blob/master/src/Microsoft.AspNet.SignalR.Client/Hubs/HubProxy.cs)
    - [WCF](https://github.com/dotnet/wcf/blob/f0b3b4935eb97807dbed7b73f25fbf160a523eac/src/System.Private.ServiceModel/src/System/ServiceModel/ChannelFactory.cs)
    - [AOP](https://github.com/autofac/Autofac.Extras.DynamicProxy)
    - [Moq](https://github.com/moq/moq4/tree/master/src/Moq/ProxyFactories)
- ### WCF Demo
  - #### ProxyPattern.ServiceProxy.MathServiceProxy
- ### Dynamic Proxy Demo 
  - #### ProxyPattern.ServiceProxy.ServiceFactory

// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/astroSign.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Server.Protos {
  public static partial class AstroSign
  {
    static readonly string __ServiceName = "AstroSign";

    static readonly grpc::Marshaller<global::Server.Protos.AstroSignLookup> __Marshaller_AstroSignLookup = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.Protos.AstroSignLookup.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Server.Protos.AstroSignResult> __Marshaller_AstroSignResult = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Server.Protos.AstroSignResult.Parser.ParseFrom);

    static readonly grpc::Method<global::Server.Protos.AstroSignLookup, global::Server.Protos.AstroSignResult> __Method_GetAstroSign = new grpc::Method<global::Server.Protos.AstroSignLookup, global::Server.Protos.AstroSignResult>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAstroSign",
        __Marshaller_AstroSignLookup,
        __Marshaller_AstroSignResult);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Server.Protos.AstroSignReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for AstroSign</summary>
    public partial class AstroSignClient : grpc::ClientBase<AstroSignClient>
    {
      /// <summary>Creates a new client for AstroSign</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AstroSignClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AstroSign that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AstroSignClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AstroSignClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AstroSignClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Server.Protos.AstroSignResult GetAstroSign(global::Server.Protos.AstroSignLookup request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAstroSign(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Server.Protos.AstroSignResult GetAstroSign(global::Server.Protos.AstroSignLookup request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAstroSign, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Server.Protos.AstroSignResult> GetAstroSignAsync(global::Server.Protos.AstroSignLookup request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAstroSignAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Server.Protos.AstroSignResult> GetAstroSignAsync(global::Server.Protos.AstroSignLookup request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAstroSign, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AstroSignClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AstroSignClient(configuration);
      }
    }

  }
}
#endregion

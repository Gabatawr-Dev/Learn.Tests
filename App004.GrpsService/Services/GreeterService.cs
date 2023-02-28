using Grpc.Core;
using App004.GrpsService.Protos.Messages;
using Google.Protobuf.WellKnownTypes;

namespace App004.GrpsService.Services;

public class GreeterService : Greeter.GreeterBase
{
    public override Task<HelloReply> Say(Empty _, ServerCallContext context) =>
        Task.FromResult(new HelloReply
        {
            Message = "Hello!"
        });

    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context) =>
        Task.FromResult(new HelloReply
        {
            Message = "Hello " + request.Name
        });
}
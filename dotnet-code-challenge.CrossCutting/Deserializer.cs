using System;

namespace dotnet_code_challenge.CrossCutting
{
    public abstract class Deserializer
    {
        public abstract T Deserialize<T>(string objectContent);


    }
}

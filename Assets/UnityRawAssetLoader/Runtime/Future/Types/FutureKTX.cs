using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Extensions.Unity.ImageLoader;
using KtxUnity;
using UnityEngine;
using UnityEngine.Networking;

namespace Extensions.Unity.RawAssetLoader
{
    public class FutureKTX : Future<KtxTexture>
    {
        public FutureKTX(string url, CancellationToken cancellationToken = new CancellationToken(), DebugLevel? logLevel = null) : base(url, cancellationToken, logLevel)
        {
        }

        protected override KtxTexture ParseBytes(byte[] bytes)
        {
            throw new System.NotImplementedException();
        }

        protected override void ReleaseMemory(KtxTexture obj, DebugLevel logLevel = DebugLevel.Log)
        {
            throw new System.NotImplementedException();
        }

        protected override KtxTexture ParseWebRequest(UnityWebRequest webRequest)
        {
            throw new System.NotImplementedException();
        }

        protected override UnityWebRequest CreateWebRequest(string url)
        {
            throw new System.NotImplementedException();
        }
    }
}
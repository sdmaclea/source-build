[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation.  All rights reserved.")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Security.Cryptography.OpenSsl")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Security.Cryptography.OpenSsl")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("1.0.24212.01")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("1.0.24212.01. Commit Hash: 9688ddbb62c04189cac4c4a06e31e93377dccd41")]
[assembly:System.Reflection.AssemblyMetadataAttribute(".NETFrameworkAssembly", "")]
[assembly:System.Reflection.AssemblyMetadataAttribute("Serviceable", "True")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft® .NET Framework")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Security.Cryptography.OpenSsl")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
namespace System.Security.Cryptography
{
    public sealed partial class ECDsaOpenSsl : System.Security.Cryptography.ECDsa
    {
        public ECDsaOpenSsl() { }
        public ECDsaOpenSsl(int keySize) { }
        public ECDsaOpenSsl(System.IntPtr handle) { }
        public ECDsaOpenSsl(System.Security.Cryptography.ECCurve curve) { }
        public ECDsaOpenSsl(System.Security.Cryptography.SafeEvpPKeyHandle pkeyHandle) { }
        public override int KeySize { get { throw null; } set { } }
        public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public System.Security.Cryptography.SafeEvpPKeyHandle DuplicateKeyHandle() { throw null; }
        public override System.Security.Cryptography.ECParameters ExportExplicitParameters(bool includePrivateParameters) { throw null; }
        public override System.Security.Cryptography.ECParameters ExportParameters(bool includePrivateParameters) { throw null; }
        public override void GenerateKey(System.Security.Cryptography.ECCurve curve) { }
        protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public override void ImportParameters(System.Security.Cryptography.ECParameters parameters) { }
        public override byte[] SignHash(byte[] hash) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature) { throw null; }
    }
    public sealed partial class RSAOpenSsl : System.Security.Cryptography.RSA
    {
        public RSAOpenSsl() { }
        public RSAOpenSsl(int keySize) { }
        public RSAOpenSsl(System.IntPtr handle) { }
        public RSAOpenSsl(System.Security.Cryptography.RSAParameters parameters) { }
        public RSAOpenSsl(System.Security.Cryptography.SafeEvpPKeyHandle pkeyHandle) { }
        public override int KeySize { set { } }
        public override System.Security.Cryptography.KeySizes[] LegalKeySizes { get { throw null; } }
        public override byte[] Decrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        protected override void Dispose(bool disposing) { }
        public System.Security.Cryptography.SafeEvpPKeyHandle DuplicateKeyHandle() { throw null; }
        public override byte[] Encrypt(byte[] data, System.Security.Cryptography.RSAEncryptionPadding padding) { throw null; }
        public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { throw null; }
        protected override byte[] HashData(byte[] data, int offset, int count, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        protected override byte[] HashData(System.IO.Stream data, System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
        public override byte[] SignHash(byte[] hash, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
    }
    public sealed partial class SafeEvpPKeyHandle : System.Runtime.InteropServices.SafeHandle
    {
        public SafeEvpPKeyHandle(System.IntPtr handle, bool ownsHandle) : base (default(System.IntPtr), default(bool)) { }
        public override bool IsInvalid { get { throw null; } }
        public System.Security.Cryptography.SafeEvpPKeyHandle DuplicateHandle() { throw null; }
        protected override bool ReleaseHandle() { throw null; }
    }
}

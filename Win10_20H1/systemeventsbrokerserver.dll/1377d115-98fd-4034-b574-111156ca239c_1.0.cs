//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\systemeventsbrokerserver.dll
// Interface ID: 1377d115-98fd-4034-b574-111156ca239c
// Interface Version: 1.0



namespace rpc_1377d115_98fd_4034_b574_111156ca239c_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
    }
    internal class _Unmarshal_Helper : NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer
    {
        public _Unmarshal_Helper(NtApiDotNet.Win32.Rpc.RpcClientResponse r) : 
                base(r.NdrBuffer, r.Handles, r.DataRepresentation)
        {
        }
        public _Unmarshal_Helper(byte[] ba) : 
                base(ba)
        {
        }
        public Struct_0 Read_0()
        {
            return ReadStruct<Struct_0>();
        }
        public int[] Read_1()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_0 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_1();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_0 CreateDefault()
        {
            Struct_0 ret = new Struct_0();
            ret.Member0 = new int[2];
            return ret;
        }
        public Struct_0(int[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("1377d115-98fd-4034-b574-111156ca239c", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint _CSebiRegisterPublisher(Struct_0 p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_0(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint CSebiPublisherUpdateLevelEvent(sbyte p0, NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteSByte(p0);
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadUInt32();
        }
        public uint CSebiUnregisterPublisher(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
    }
    #endregion
}

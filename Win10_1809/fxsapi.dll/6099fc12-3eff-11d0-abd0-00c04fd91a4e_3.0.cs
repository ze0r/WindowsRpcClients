//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\FXSAPI.dll
// Interface ID: 6099fc12-3eff-11d0-abd0-00c04fd91a4e
// Interface Version: 3.0



namespace rpc_6099fc12_3eff_11d0_abd0_00c04fd91a4e_3_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_0 p0)
        {
            WriteStruct<Struct_0>(p0);
        }
        public void Write_1(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_2(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
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
        public Struct_1 Read_1()
        {
            return ReadStruct<Struct_1>();
        }
        public sbyte[] Read_2()
        {
            return ReadConformantArray<sbyte>();
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
            m.WriteInt32(Member0);
            m.Write_1(Member4);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
            m.WriteInt32(Member14);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_1();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
            Member14 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_1 Member4;
        public int MemberC;
        public int Member10;
        public int Member14;
        public static Struct_0 CreateDefault()
        {
            return new Struct_0();
        }
        public Struct_0(int Member0, Struct_1 Member4, int MemberC, int Member10, int Member14)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member14 = Member14;
        }
    }
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(int Member0, int Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("6099fc12-3eff-11d0-abd0-00c04fd91a4e", 3, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public uint FAX_OpenConnection(long p0, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt64(p0);
            _Unmarshal_Helper u = SendReceive(0, m);
            p1 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint FAX_ClientEventQueue(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, Struct_0 p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_0(p1);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadUInt32();
        }
        public uint FAX_CloseConnection(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(2, m);
            p0 = u.ReadContextHandle();
            return u.ReadUInt32();
        }
        public uint FAX_ClientEventQueueEx(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0, sbyte[] p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            m.Write_2(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p2);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadUInt32();
        }
    }
    #endregion
}


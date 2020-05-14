//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\bisrv.dll
// Interface ID: 2513bcbe-6cd4-4348-855e-7efb3c336dd3
// Interface Version: 2.0



namespace rpc_2513bcbe_6cd4_4348_855e_7efb3c336dd3_2_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_1(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_2(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_3(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
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
        public Struct_1 Read_0()
        {
            return ReadStruct<Struct_1>();
        }
        public byte[] Read_1()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_2()
        {
            return ReadConformantArray<byte>();
        }
        public byte[] Read_3()
        {
            return ReadConformantArray<byte>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteUInt3264(Member0);
            m.WriteInt32(Member8);
            m.WriteInt32(MemberC);
            m.WriteInt32(Member10);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadUInt3264();
            Member8 = u.ReadInt32();
            MemberC = u.ReadInt32();
            Member10 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0;
        public int Member8;
        public int MemberC;
        public int Member10;
        public static Struct_1 CreateDefault()
        {
            return new Struct_1();
        }
        public Struct_1(NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member0, int Member8, int MemberC, int Member10)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("2513bcbe-6cd4-4348-855e-7efb3c336dd3", 2, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int SrvOdbCreateSession(int p0, byte[] p1, string p2, int p3, out int p4, out long p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p3);
            _Unmarshal_Helper u = SendReceive(0, m);
            p4 = u.ReadInt32();
            p5 = u.ReadInt64();
            return u.ReadInt32();
        }
        public int SrvOdbCompleteSession(int p0, byte[] p1, int p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteInt32(p2);
            _Unmarshal_Helper u = SendReceive(1, m);
            return u.ReadInt32();
        }
        public int SrvOdbLaunchBackgroundTask(int p0, byte[] p1, int p2, byte[] p3, int p4, string p5, string p6, System.Nullable<System.Guid> p7, byte[] p8, int p9, System.Nullable<Struct_1> p10, System.Nullable<System.Guid> p11, out System.Guid p12)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteInt32(p2);
            m.WriteReferent(p3, new System.Action<byte[], long>(m.Write_2), p2);
            m.WriteInt32(p4);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p5, "p5"));
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p6, "p6"));
            m.WriteReferent(p7, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p8, new System.Action<byte[], long>(m.Write_3), p9);
            m.WriteInt32(p9);
            m.WriteReferent(p10, new System.Action<Struct_1>(m.Write_0));
            m.WriteReferent(p11, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(2, m);
            p12 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int SrvOdbCancelBackgroundTask(int p0, byte[] p1, int p2, System.Guid p3, sbyte p4, int p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.Write_1(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p1, "p1"), p0);
            m.WriteInt32(p2);
            m.WriteGuid(p3);
            m.WriteSByte(p4);
            m.WriteInt32(p5);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

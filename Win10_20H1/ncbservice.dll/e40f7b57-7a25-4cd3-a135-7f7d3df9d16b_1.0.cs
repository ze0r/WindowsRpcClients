//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Source Executable: c:\windows\system32\ncbservice.dll
// Interface ID: e40f7b57-7a25-4cd3-a135-7f7d3df9d16b
// Interface Version: 1.0



namespace rpc_e40f7b57_7a25_4cd3_a135_7f7d3df9d16b_1_0
{
    
    #region Marshal Helpers
    internal class _Marshal_Helper : NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer
    {
        public void Write_0(Struct_1 p0)
        {
            WriteStruct<Struct_1>(p0);
        }
        public void Write_1(Struct_2 p0)
        {
            WriteStruct<Struct_2>(p0);
        }
        public void Write_2(Struct_3 p0)
        {
            WriteStruct<Struct_3>(p0);
        }
        public void Write_3(Struct_4 p0)
        {
            WriteStruct<Struct_4>(p0);
        }
        public void Write_4(Struct_5 p0)
        {
            WriteStruct<Struct_5>(p0);
        }
        public void Write_5(Struct_6 p0)
        {
            WriteStruct<Struct_6>(p0);
        }
        public void Write_6(Struct_7 p0)
        {
            WriteStruct<Struct_7>(p0);
        }
        public void Write_7(Struct_8 p0)
        {
            WriteStruct<Struct_8>(p0);
        }
        public void Write_8(Struct_9 p0)
        {
            WriteStruct<Struct_9>(p0);
        }
        public void Write_9(Struct_10 p0)
        {
            WriteStruct<Struct_10>(p0);
        }
        public void Write_10(Struct_11 p0)
        {
            WriteStruct<Struct_11>(p0);
        }
        public void Write_11(Struct_12 p0)
        {
            WriteStruct<Struct_12>(p0);
        }
        public void Write_12(Struct_13 p0)
        {
            WriteStruct<Struct_13>(p0);
        }
        public void Write_13(byte[] p0, long p1)
        {
            WriteConformantArray<byte>(p0, p1);
        }
        public void Write_14(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_15(sbyte[] p0, long p1)
        {
            WriteConformantArray<sbyte>(p0, p1);
        }
        public void Write_16(Struct_6[] p0, long p1)
        {
            WriteConformantStructArray<Struct_6>(p0, p1);
        }
        public void Write_17(string[] p0, long p1)
        {
            WriteConformantStringArray(p0, new System.Action<string>(this.WriteTerminatedString), p1);
        }
        public void Write_18(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 4);
        }
        public void Write_19(Struct_10[] p0, long p1)
        {
            WriteConformantStructArray<Struct_10>(p0, p1);
        }
        public void Write_20(Struct_12[] p0, long p1)
        {
            WriteConformantStructArray<Struct_12>(p0, p1);
        }
        public void Write_21(string p0)
        {
            WriteFixedString(p0, 257);
        }
        public void Write_22(int[] p0)
        {
            WriteFixedPrimitiveArray<int>(p0, 2);
        }
        public void Write_23(char[] p0, long p1)
        {
            WriteConformantArray<char>(p0, p1);
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
        public Struct_2 Read_1()
        {
            return ReadStruct<Struct_2>();
        }
        public Struct_3 Read_2()
        {
            return ReadStruct<Struct_3>();
        }
        public Struct_4 Read_3()
        {
            return ReadStruct<Struct_4>();
        }
        public Struct_5 Read_4()
        {
            return ReadStruct<Struct_5>();
        }
        public Struct_6 Read_5()
        {
            return ReadStruct<Struct_6>();
        }
        public Struct_7 Read_6()
        {
            return ReadStruct<Struct_7>();
        }
        public Struct_8 Read_7()
        {
            return ReadStruct<Struct_8>();
        }
        public Struct_9 Read_8()
        {
            return ReadStruct<Struct_9>();
        }
        public Struct_10 Read_9()
        {
            return ReadStruct<Struct_10>();
        }
        public Struct_11 Read_10()
        {
            return ReadStruct<Struct_11>();
        }
        public Struct_12 Read_11()
        {
            return ReadStruct<Struct_12>();
        }
        public Struct_13 Read_12()
        {
            return ReadStruct<Struct_13>();
        }
        public byte[] Read_13()
        {
            return ReadConformantArray<byte>();
        }
        public sbyte[] Read_14()
        {
            return ReadConformantArray<sbyte>();
        }
        public sbyte[] Read_15()
        {
            return ReadConformantArray<sbyte>();
        }
        public Struct_6[] Read_16()
        {
            return ReadConformantStructArray<Struct_6>();
        }
        public string[] Read_17()
        {
            return ReadConformantStringArray(new System.Func<string>(this.ReadConformantVaryingString));
        }
        public int[] Read_18()
        {
            return ReadFixedPrimitiveArray<int>(4);
        }
        public Struct_10[] Read_19()
        {
            return ReadConformantStructArray<Struct_10>();
        }
        public Struct_12[] Read_20()
        {
            return ReadConformantStructArray<Struct_12>();
        }
        public string Read_21()
        {
            return ReadFixedString(257);
        }
        public int[] Read_22()
        {
            return ReadFixedPrimitiveArray<int>(2);
        }
        public char[] Read_23()
        {
            return ReadConformantArray<char>();
        }
    }
    #endregion
    #region Complex Types
    public struct Struct_1 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_13(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_13();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public byte[] Member4;
        public static Struct_1 CreateDefault()
        {
            Struct_1 ret = new Struct_1();
            ret.Member4 = new byte[0];
            return ret;
        }
        public Struct_1(int Member0, byte[] Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_2 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            m.Write_2(Member8);
            m.Write_3(Member18);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member8 = u.Read_2();
            Member18 = u.Read_3();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
        public Struct_3 Member8;
        public Struct_4 Member18;
        public static Struct_2 CreateDefault()
        {
            return new Struct_2();
        }
        public Struct_2(string Member0, Struct_3 Member8, Struct_4 Member18)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member18 = Member18;
        }
    }
    public struct Struct_3 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_14), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_14), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
        public static Struct_3 CreateDefault()
        {
            return new Struct_3();
        }
        public Struct_3(int Member0, int Member4, sbyte[] Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Struct_4 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteEmbeddedPointer<sbyte[], long>(Member8, new System.Action<sbyte[], long>(m.Write_14), Member0);
            m.WriteEmbeddedPointer<sbyte[], long>(Member10, new System.Action<sbyte[], long>(m.Write_15), Member4);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_14), false);
            Member10 = u.ReadEmbeddedPointer<sbyte[]>(new System.Func<sbyte[]>(u.Read_15), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<sbyte[]> Member10;
        public static Struct_4 CreateDefault()
        {
            return new Struct_4();
        }
        public Struct_4(int Member0, int Member4, sbyte[] Member8, sbyte[] Member10)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.Member10 = Member10;
        }
    }
    public struct Struct_5 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_16(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member8 = u.Read_16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_6[] Member8;
        public static Struct_5 CreateDefault()
        {
            Struct_5 ret = new Struct_5();
            ret.Member8 = new Struct_6[0];
            return ret;
        }
        public Struct_5(int Member0, Struct_6[] Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_6 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<Struct_7>(Member0, new System.Action<Struct_7>(m.Write_6));
            m.WriteSByte(Member8);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<Struct_7>(new System.Func<Struct_7>(u.Read_6), false);
            Member8 = u.ReadSByte();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_7> Member0;
        public sbyte Member8;
        public static Struct_6 CreateDefault()
        {
            return new Struct_6();
        }
        public Struct_6(System.Nullable<Struct_7> Member0, sbyte Member8)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
        }
    }
    public struct Struct_7 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteEmbeddedPointer<string>(Member0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<string>(Member8, new System.Action<string>(m.WriteTerminatedString));
            m.WriteEmbeddedPointer<int>(Member10, new System.Action<int>(m.WriteInt32));
            m.WriteEmbeddedPointer<Struct_8>(Member18, new System.Action<Struct_8>(m.Write_7));
            m.WriteInt16(Member20);
            m.WriteInt16(Member22);
            m.WriteInt16(Member24);
            m.WriteInt32(Member28);
            m.WriteEmbeddedPointer<string[], long>(Member30, new System.Action<string[], long>(m.Write_17), Member28);
            m.WriteEmbeddedPointer<string[], long>(Member38, new System.Action<string[], long>(m.Write_17), Member28);
            m.WriteInt32(Member40);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member8 = u.ReadEmbeddedPointer<string>(new System.Func<string>(u.ReadConformantVaryingString), false);
            Member10 = u.ReadEmbeddedPointer<int>(new System.Func<int>(u.ReadInt32), false);
            Member18 = u.ReadEmbeddedPointer<Struct_8>(new System.Func<Struct_8>(u.Read_7), false);
            Member20 = u.ReadInt16();
            Member22 = u.ReadInt16();
            Member24 = u.ReadInt16();
            Member28 = u.ReadInt32();
            Member30 = u.ReadEmbeddedPointer<string[]>(new System.Func<string[]>(u.Read_17), false);
            Member38 = u.ReadEmbeddedPointer<string[]>(new System.Func<string[]>(u.Read_17), false);
            Member40 = u.ReadInt32();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string> Member8;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<int> Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_8> Member18;
        public short Member20;
        public short Member22;
        public short Member24;
        public int Member28;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string[]> Member30;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<string[]> Member38;
        public int Member40;
        public static Struct_7 CreateDefault()
        {
            return new Struct_7();
        }
        public Struct_7(string Member0, string Member8, System.Nullable<int> Member10, System.Nullable<Struct_8> Member18, short Member20, short Member22, short Member24, int Member28, string[] Member30, string[] Member38, int Member40)
        {
            this.Member0 = Member0;
            this.Member8 = Member8;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member22 = Member22;
            this.Member24 = Member24;
            this.Member28 = Member28;
            this.Member30 = Member30;
            this.Member38 = Member38;
            this.Member40 = Member40;
        }
    }
    public struct Struct_8 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_18(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_18();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_8 CreateDefault()
        {
            Struct_8 ret = new Struct_8();
            ret.Member0 = new int[4];
            return ret;
        }
        public Struct_8(int[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    public struct Struct_9 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteEnum16(Member4);
            m.Write_19(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member8, "Member8"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadEnum16();
            Member8 = u.Read_19();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4;
        public Struct_10[] Member8;
        public static Struct_9 CreateDefault()
        {
            Struct_9 ret = new Struct_9();
            ret.Member8 = new Struct_10[0];
            return ret;
        }
        public Struct_9(int Member0, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member4, Struct_10[] Member8)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
        }
    }
    public struct Struct_10 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.WriteInt32(Member4);
            m.WriteInt32(Member8);
            m.WriteSByte(MemberC);
            m.WriteInt32(Member10);
            m.WriteUInt3264(Member18);
            m.WriteEmbeddedPointer<Struct_2>(Member20, new System.Action<Struct_2>(m.Write_1));
            m.WriteEmbeddedPointer<Struct_5>(Member28, new System.Action<Struct_5>(m.Write_4));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.ReadInt32();
            Member8 = u.ReadInt32();
            MemberC = u.ReadSByte();
            Member10 = u.ReadInt32();
            Member18 = u.ReadUInt3264();
            Member20 = u.ReadEmbeddedPointer<Struct_2>(new System.Func<Struct_2>(u.Read_1), false);
            Member28 = u.ReadEmbeddedPointer<Struct_5>(new System.Func<Struct_5>(u.Read_4), false);
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public int Member4;
        public int Member8;
        public sbyte MemberC;
        public int Member10;
        public NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member18;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_2> Member20;
        public NtApiDotNet.Ndr.Marshal.NdrEmbeddedPointer<Struct_5> Member28;
        public static Struct_10 CreateDefault()
        {
            return new Struct_10();
        }
        public Struct_10(int Member0, int Member4, int Member8, sbyte MemberC, int Member10, NtApiDotNet.Ndr.Marshal.NdrUInt3264 Member18, System.Nullable<Struct_2> Member20, System.Nullable<Struct_5> Member28)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
            this.Member8 = Member8;
            this.MemberC = MemberC;
            this.Member10 = Member10;
            this.Member18 = Member18;
            this.Member20 = Member20;
            this.Member28 = Member28;
        }
    }
    public struct Struct_11 : NtApiDotNet.Ndr.Marshal.INdrConformantStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteInt32(Member0);
            m.Write_20(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member4, "Member4"), Member0);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadInt32();
            Member4 = u.Read_20();
        }
        int NtApiDotNet.Ndr.Marshal.INdrConformantStructure.GetConformantDimensions()
        {
            return 1;
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int Member0;
        public Struct_12[] Member4;
        public static Struct_11 CreateDefault()
        {
            Struct_11 ret = new Struct_11();
            ret.Member4 = new Struct_12[0];
            return ret;
        }
        public Struct_11(int Member0, Struct_12[] Member4)
        {
            this.Member0 = Member0;
            this.Member4 = Member4;
        }
    }
    public struct Struct_12 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.WriteGuid(Member0);
            m.Write_21(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member10, "Member10"));
            m.WriteEnum16(Member214);
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.ReadGuid();
            Member10 = u.Read_21();
            Member214 = u.ReadEnum16();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public System.Guid Member0;
        public string Member10;
        public NtApiDotNet.Ndr.Marshal.NdrEnum16 Member214;
        public static Struct_12 CreateDefault()
        {
            Struct_12 ret = new Struct_12();
            ret.Member10 = new string('\0', 257);
            return ret;
        }
        public Struct_12(System.Guid Member0, string Member10, NtApiDotNet.Ndr.Marshal.NdrEnum16 Member214)
        {
            this.Member0 = Member0;
            this.Member10 = Member10;
            this.Member214 = Member214;
        }
    }
    public struct Struct_13 : NtApiDotNet.Ndr.Marshal.INdrStructure
    {
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Marshal(NtApiDotNet.Ndr.Marshal.NdrMarshalBuffer m)
        {
            Marshal(((_Marshal_Helper)(m)));
        }
        private void Marshal(_Marshal_Helper m)
        {
            m.Write_22(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(Member0, "Member0"));
        }
        void NtApiDotNet.Ndr.Marshal.INdrStructure.Unmarshal(NtApiDotNet.Ndr.Marshal.NdrUnmarshalBuffer u)
        {
            Unmarshal(((_Unmarshal_Helper)(u)));
        }
        private void Unmarshal(_Unmarshal_Helper u)
        {
            Member0 = u.Read_22();
        }
        int NtApiDotNet.Ndr.Marshal.INdrStructure.GetAlignment()
        {
            return 4;
        }
        public int[] Member0;
        public static Struct_13 CreateDefault()
        {
            Struct_13 ret = new Struct_13();
            ret.Member0 = new int[2];
            return ret;
        }
        public Struct_13(int[] Member0)
        {
            this.Member0 = Member0;
        }
    }
    #endregion
    #region Client Implementation
    public sealed class Client : NtApiDotNet.Win32.Rpc.RpcClientBase
    {
        public Client() : 
                base("e40f7b57-7a25-4cd3-a135-7f7d3df9d16b", 1, 0)
        {
        }
        private _Unmarshal_Helper SendReceive(int p, _Marshal_Helper m)
        {
            return new _Unmarshal_Helper(SendReceive(p, m.DataRepresentation, m.ToArray(), m.Handles));
        }
        public int RpcSrvCreateSession(char[] p0, int p1, sbyte p2, NtApiDotNet.Ndr.Marshal.NdrEnum16 p3, System.Guid p4, System.Guid p5, out NtApiDotNet.Ndr.Marshal.NdrContextHandle p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.Write_23(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p0, "p0"), p1);
            m.WriteInt32(p1);
            m.WriteSByte(p2);
            m.WriteEnum16(p3);
            m.WriteGuid(p4);
            m.WriteGuid(p5);
            _Unmarshal_Helper u = SendReceive(0, m);
            p6 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcSrvDestroySession(ref NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(1, m);
            p0 = u.ReadContextHandle();
            return u.ReadInt32();
        }
        public int RpcSrvStartBrokeredActivation(int p0, sbyte p1, int p2, out System.Guid p3, out System.Guid p4, NtApiDotNet.Ndr.Marshal.NdrContextHandle p5)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteSByte(p1);
            m.WriteInt32(p2);
            m.WriteContextHandle(p5);
            _Unmarshal_Helper u = SendReceive(2, m);
            p3 = u.ReadGuid();
            p4 = u.ReadGuid();
            return u.ReadInt32();
        }
        public int RpcSrvSetServerKeepAliveInterval(int p0, NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteInt32(p0);
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(3, m);
            return u.ReadInt32();
        }
        public int RpcSrvGetCurrentKeepAliveInterval(out int p0, NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(4, m);
            p0 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcSrvDecreaseKeepAliveInterval(NtApiDotNet.Ndr.Marshal.NdrContextHandle p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p0);
            _Unmarshal_Helper u = SendReceive(5, m);
            return u.ReadInt32();
        }
        public int RpcSrvUsingTransport(out long p0, NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(6, m);
            p0 = u.ReadInt64();
            return u.ReadInt32();
        }
        public int RpcSrvIndicateSlotAllocation(sbyte p0, NtApiDotNet.Ndr.Marshal.NdrContextHandle p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteSByte(p0);
            m.WriteContextHandle(p1);
            _Unmarshal_Helper u = SendReceive(7, m);
            return u.ReadInt32();
        }
        public int RpcSrvSBCreatePushEnabledContext(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(8, m);
            return u.ReadInt32();
        }
        public int RpcSrvSBTransferOwnership(string p0, System.Guid p1, string p2, int p3, int p4, int p5, int p6, sbyte p7, NtApiDotNet.Ndr.Marshal.NdrUInt3264 p8, int p9, System.Nullable<Struct_1> p10, System.Nullable<Struct_2> p11, System.Nullable<Struct_5> p12)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteInt32(p3);
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.WriteInt32(p6);
            m.WriteSByte(p7);
            m.WriteUInt3264(p8);
            m.WriteInt32(p9);
            m.WriteReferent(p10, new System.Action<Struct_1>(m.Write_0));
            m.WriteReferent(p11, new System.Action<Struct_2>(m.Write_1));
            m.WriteReferent(p12, new System.Action<Struct_5>(m.Write_4));
            _Unmarshal_Helper u = SendReceive(9, m);
            return u.ReadInt32();
        }
        public int RpcSrvSBRetrieveSocket(string p0, System.Guid p1, string p2, sbyte p3, out System.Nullable<Struct_9> p4)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            m.WriteSByte(p3);
            _Unmarshal_Helper u = SendReceive(10, m);
            p4 = u.ReadReferentValue<Struct_9>(new System.Func<Struct_9>(u.Read_8), false);
            return u.ReadInt32();
        }
        public int RpcSrvSBCompleteRetrieveSocket(string p0, System.Guid p1, string p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            _Unmarshal_Helper u = SendReceive(11, m);
            return u.ReadInt32();
        }
        public int RpcSrvSBRetrieveContext(string p0, System.Guid p1, string p2, out System.Nullable<Struct_1> p3)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteGuid(p1);
            m.WriteTerminatedString(NtApiDotNet.Win32.Rpc.RpcUtils.CheckNull(p2, "p2"));
            _Unmarshal_Helper u = SendReceive(12, m);
            p3 = u.ReadReferentValue<Struct_1>(new System.Func<Struct_1>(u.Read_0), false);
            return u.ReadInt32();
        }
        public int RpcSrvSBEnumSockets(string p0, out System.Nullable<Struct_11> p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(13, m);
            p1 = u.ReadReferentValue<Struct_11>(new System.Func<Struct_11>(u.Read_10), false);
            return u.ReadInt32();
        }
        public int RpcSrvHotspotRegisterHotspotApp(string p0, string p1, ref System.Nullable<System.Guid> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p2, new System.Action<System.Guid>(m.WriteGuid));
            _Unmarshal_Helper u = SendReceive(14, m);
            p2 = u.ReadReferentValue<System.Guid>(new System.Func<System.Guid>(u.ReadGuid), false);
            return u.ReadInt32();
        }
        public int RpcSrvHotspotFindEventForPackage(string p0, ref System.Nullable<System.Guid> p1, ref System.Nullable<Struct_13> p2)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p1, new System.Action<System.Guid>(m.WriteGuid));
            m.WriteReferent(p2, new System.Action<Struct_13>(m.Write_12));
            _Unmarshal_Helper u = SendReceive(15, m);
            p1 = u.ReadReferentValue<System.Guid>(new System.Func<System.Guid>(u.ReadGuid), false);
            p2 = u.ReadReferentValue<Struct_13>(new System.Func<Struct_13>(u.Read_12), false);
            return u.ReadInt32();
        }
        public int RpcSrvHotspotTriggerBackgroundEvent(System.Guid p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteGuid(p0);
            _Unmarshal_Helper u = SendReceive(16, m);
            return u.ReadInt32();
        }
        public int RpcSrvHotspotIsAppInstalled(string p0, out int p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(17, m);
            p1 = u.ReadInt32();
            return u.ReadInt32();
        }
        public int RpcSrvFirewallWcmSetFirewallRule(string p0, string p1, string p2, string p3, int p4, int p5, short p6)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p1, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p2, new System.Action<string>(m.WriteTerminatedString));
            m.WriteReferent(p3, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt32(p4);
            m.WriteInt32(p5);
            m.WriteInt16(p6);
            _Unmarshal_Helper u = SendReceive(18, m);
            return u.ReadInt32();
        }
        public int RpcSrvFirewallWcmSetFirewallRuleFlags(string p0, short p1)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            m.WriteInt16(p1);
            _Unmarshal_Helper u = SendReceive(19, m);
            return u.ReadInt32();
        }
        public int RpcSrvFirewallWcmDeleteFirewallRule(string p0)
        {
            _Marshal_Helper m = new _Marshal_Helper();
            m.WriteReferent(p0, new System.Action<string>(m.WriteTerminatedString));
            _Unmarshal_Helper u = SendReceive(20, m);
            return u.ReadInt32();
        }
    }
    #endregion
}

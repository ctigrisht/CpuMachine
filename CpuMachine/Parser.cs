using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CpuMachine
{
    public class Instance
    {
        public string Instructions = string.Empty;
        public bool Running { get; set; }
        public short CoreCount { get; set; } = 2;
        public short StackCount { get; set; } = 32;
        public short QueueCount { get; set; } = 8;



        public List<(int, ConcurrentStack<(object, Type)>)> StackRegisters = new List<(int, ConcurrentStack<(object, Type)>)>();
        public List<(int, ConcurrentQueue<(object, Type)>)> QueueRegisters = new List<(int, ConcurrentQueue<(object, Type)>)>();
        public List<(object, Type)> ListRegisters = new List<(object, Type)>();

        public async Task RunAsync()
        {

        }

        // EXEC VALUES
        public (object, Type) ExecReg0 = (0, typeof(int));
        public (object, Type) ExecReg1 = (0, typeof(int));
        public (object, Type) ExecReg2 = (0, typeof(int));
        public (object, Type) ExecReg3 = (0, typeof(int));
        public (object, Type) ExecReg4 = (0, typeof(int));
        public (object, Type) ExecReg5 = (0, typeof(int));
        public (object, Type) ExecReg6 = (0, typeof(int));
        public (object, Type) ExecReg7 = (0, typeof(int));
        public (object, Type) ExecReg8 = (0, typeof(int));
        public (object, Type) ExecReg9 = (0, typeof(int));
        public (object, Type) ExecReg10 = (0, typeof(int));
        public (object, Type) ExecReg11 = (0, typeof(int));
        public (object, Type) ExecReg12 = (0, typeof(int));
        public (object, Type) ExecReg13 = (0, typeof(int));
        public (object, Type) ExecReg14 = (0, typeof(int));
        public (object, Type) ExecReg15 = (0, typeof(int));
        public List<(object, Type)> DataListReg = new List<(object, Type)>();

    }

    public static class Engine
    {

    }

    public enum Instruction
    {
        /// <summary>
        /// Add a value to register
        /// </summary>
        ADD = 00001,
        /// <summary>
        /// Take a value from register
        /// </summary>
        POP = 00002,
        /// <summary>
        /// Transfer a value to another register
        /// </summary>
        SWC = 00003,
        /// <summary>
        /// Print to console
        /// </summary>
        PRT = 00004,
        /// <summary>
        /// Get a value from register
        /// </summary>
        GET = 00005,
        /// <summary>
        /// Set a value to a specific index in register
        /// </summary>
        SET = 00006,
        /// <summary>
        /// Math Add, Adds all arg values
        /// </summary>
        MADD = 00007,
        /// <summary>
        /// Math Substract, substracts from first value in arguments
        /// </summary>
        MSUB = 00008,
    }
}

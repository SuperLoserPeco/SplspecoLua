﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Api
{
    public enum OpCodeEnum
    {
        OP_MOVE,

        OP_LOADK,

        OP_LOADKX,

        OP_LOADBOOL,

        OP_LOADNIL,

        OP_GETUPVAL,

        OP_GETTABUP,

        OP_GETTABLE,

        OP_SETTABUP,

        OP_SETUPVAL,

        OP_SETTABLE,

        OP_NEWTABLE,

        OP_SELF,

        OP_ADD,

        OP_SUB,

        OP_MUL,

        OP_MOD,

        OP_POW,

        OP_DIV,

        OP_IDIV,

        OP_BAND,

        OP_BOR,

        OP_BXOR,

        OP_SHL,

        OP_SHR,

        OP_UNM,

        OP_BNOT,

        OP_NOT,

        OP_LEN,

        OP_CONCAT,

        OP_JMP,

        OP_EQ,

        OP_LT,

        OP_LE,

        OP_TEST,

        OP_TESTSET,

        OP_CALL,

        OP_TAILCALL,

        OP_RETURN,

        OP_FORLOOP,

        OP_FORPREP,

        OP_TFORCALL,

        OP_TFORLOOP,

        OP_SETLIST,

        OP_CLOSURE,

        OP_VARARG,

        OP_EXTRAARG,
    }
}














//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class MakeArray : ReqlExpr {

    
    
    
        public MakeArray (object arg) : this(new Arguments(arg), null) {
        }
        public MakeArray (Arguments args) : this(args, null) {
        }
        public MakeArray (Arguments args, OptArgs optargs)
         : base(TermType.MAKE_ARRAY, args, optargs) {
        }


    



    


    

    


    
    }
}

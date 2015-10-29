












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

    public class Range : ReqlExpr {

    
    
    
/// <summary>
/// <para>Generate a stream of sequential integers in a specified range.</para>
/// </summary>
/// <example><para>Example: Return a four-element range of <code>[0, 1, 2, 3]</code>.</para>
/// <code>&gt; r.range(4).run(conn, callback)
/// 
/// [0, 1, 2, 3]
/// </code></example>
        public Range (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Generate a stream of sequential integers in a specified range.</para>
/// </summary>
/// <example><para>Example: Return a four-element range of <code>[0, 1, 2, 3]</code>.</para>
/// <code>&gt; r.range(4).run(conn, callback)
/// 
/// [0, 1, 2, 3]
/// </code></example>
        public Range (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Generate a stream of sequential integers in a specified range.</para>
/// </summary>
/// <example><para>Example: Return a four-element range of <code>[0, 1, 2, 3]</code>.</para>
/// <code>&gt; r.range(4).run(conn, callback)
/// 
/// [0, 1, 2, 3]
/// </code></example>
        public Range (Arguments args, OptArgs optargs)
         : base(TermType.RANGE, args, optargs) {
        }


    



    


    

    


    
    }
}

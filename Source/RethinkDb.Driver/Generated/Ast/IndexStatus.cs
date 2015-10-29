












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

    public class IndexStatus : ReqlExpr {

    
    
    
/// <summary>
/// <para>Get the status of the specified indexes on this table, or the status
/// of all indexes on this table if no indexes are specified.</para>
/// </summary>
/// <example><para>Example: Get the status of all the indexes on <code>test</code>:</para>
/// <code>r.table('test').indexStatus().run(conn, callback)
/// </code>
/// <para>Example: Get the status of the <code>timestamp</code> index:</para>
/// <code>r.table('test').indexStatus('timestamp').run(conn, callback)
/// </code></example>
        public IndexStatus (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Get the status of the specified indexes on this table, or the status
/// of all indexes on this table if no indexes are specified.</para>
/// </summary>
/// <example><para>Example: Get the status of all the indexes on <code>test</code>:</para>
/// <code>r.table('test').indexStatus().run(conn, callback)
/// </code>
/// <para>Example: Get the status of the <code>timestamp</code> index:</para>
/// <code>r.table('test').indexStatus('timestamp').run(conn, callback)
/// </code></example>
        public IndexStatus (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Get the status of the specified indexes on this table, or the status
/// of all indexes on this table if no indexes are specified.</para>
/// </summary>
/// <example><para>Example: Get the status of all the indexes on <code>test</code>:</para>
/// <code>r.table('test').indexStatus().run(conn, callback)
/// </code>
/// <para>Example: Get the status of the <code>timestamp</code> index:</para>
/// <code>r.table('test').indexStatus('timestamp').run(conn, callback)
/// </code></example>
        public IndexStatus (Arguments args, OptArgs optargs)
         : base(TermType.INDEX_STATUS, args, optargs) {
        }


    



    


    

    


    
    }
}

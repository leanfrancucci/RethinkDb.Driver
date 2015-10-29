












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

    public class SetIntersection : ReqlExpr {

    
    
    
/// <summary>
/// <para>Intersect two arrays returning values that occur in both of them as a set (an array with
/// distinct values).</para>
/// </summary>
/// <example><para>Example: Check which pieces of equipment Iron Man has from a fixed list.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').setIntersection(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetIntersection (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Intersect two arrays returning values that occur in both of them as a set (an array with
/// distinct values).</para>
/// </summary>
/// <example><para>Example: Check which pieces of equipment Iron Man has from a fixed list.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').setIntersection(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetIntersection (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Intersect two arrays returning values that occur in both of them as a set (an array with
/// distinct values).</para>
/// </summary>
/// <example><para>Example: Check which pieces of equipment Iron Man has from a fixed list.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').setIntersection(['newBoots', 'arc_reactor']).run(conn, callback)
/// </code></example>
        public SetIntersection (Arguments args, OptArgs optargs)
         : base(TermType.SET_INTERSECTION, args, optargs) {
        }


    



    


    

    


    
    }
}

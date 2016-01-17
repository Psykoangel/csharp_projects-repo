// Type: System.Drawing.Size
// Assembly: System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Drawing.dll

using System;
using System.ComponentModel;
using System.Runtime;
using System.Runtime.InteropServices;

namespace System.Drawing
{
    /// <summary>
    /// Stocke une paire ordonnée d'entiers, représentant généralement la largeur et la hauteur d'un rectangle.
    /// </summary>
    /// <filterpriority>1</filterpriority>
    [TypeConverter(typeof (SizeConverter))]
    [ComVisible(true)]
    [Serializable]
    public struct Size
    {
        /// <summary>
        /// Obtient une structure <see cref="T:System.Drawing.Size"/> dont les valeurs <see cref="P:System.Drawing.Size.Height"/> et <see cref="P:System.Drawing.Size.Width"/> sont égales à 0.
        /// </summary>
        /// 
        /// <returns>
        /// <see cref="T:System.Drawing.Size"/> dont les valeurs <see cref="P:System.Drawing.Size.Height"/> et <see cref="P:System.Drawing.Size.Width"/> sont égales à 0.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public static readonly Size Empty;

        /// <summary>
        /// Initialise une nouvelle instance de la structure <see cref="T:System.Drawing.Size"/> à partir de la structure <see cref="T:System.Drawing.Point"/> spécifiée.
        /// </summary>
        /// <param name="pt">Structure <see cref="T:System.Drawing.Point"/> à partir de laquelle initialiser cette structure <see cref="T:System.Drawing.Size"/>. </param>
        public Size(Point pt);

        /// <summary>
        /// Initialise une nouvelle instance de la structure <see cref="T:System.Drawing.Size"/> à partir des dimensions spécifiées.
        /// </summary>
        /// <param name="width">Composant de largeur du nouveau <see cref="T:System.Drawing.Size"/>. </param><param name="height">Composant de hauteur du nouveau <see cref="T:System.Drawing.Size"/>. </param>
        public Size(int width, int height);

        /// <summary>
        /// Convertit la structure <see cref="T:System.Drawing.Size"/> spécifiée en structure <see cref="T:System.Drawing.SizeF"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.SizeF"/> vers laquelle cet opérateur effectue la conversion.
        /// </returns>
        /// <param name="p">Structure <see cref="T:System.Drawing.Size"/> à convertir. </param><filterpriority>3</filterpriority>
        public static implicit operator SizeF(Size p);

        /// <summary>
        /// Ajoute la largeur et la hauteur d'une structure <see cref="T:System.Drawing.Size"/> à la largeur et la hauteur d'une autre structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.Size"/> qui est le résultat de l'opération d'addition.
        /// </returns>
        /// <param name="sz1">Premier <see cref="T:System.Drawing.Size"/> à ajouter. </param><param name="sz2">Deuxième <see cref="T:System.Drawing.Size"/> à ajouter. </param><filterpriority>3</filterpriority>
        public static Size operator +(Size sz1, Size sz2);

        /// <summary>
        /// Soustrait la largeur et la hauteur d'une structure <see cref="T:System.Drawing.Size"/> de la largeur et de la hauteur d'une autre structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.Size"/> qui est le résultat de l'opération de soustraction.
        /// </returns>
        /// <param name="sz1">Structure <see cref="T:System.Drawing.Size"/> à gauche de l'opérateur de soustraction. </param><param name="sz2">Structure <see cref="T:System.Drawing.Size"/> à droite de l'opérateur de soustraction. </param><filterpriority>3</filterpriority>
        public static Size operator -(Size sz1, Size sz2);

        /// <summary>
        /// Teste si deux structures <see cref="T:System.Drawing.Size"/> sont égales.
        /// </summary>
        /// 
        /// <returns>
        /// true si <paramref name="sz1"/> et <paramref name="sz2"/> ont une largeur et une hauteur égales ; sinon, false.
        /// </returns>
        /// <param name="sz1">Structure <see cref="T:System.Drawing.Size"/> à gauche de l'opérateur d'égalité. </param><param name="sz2">Structure <see cref="T:System.Drawing.Size"/> à droite de l'opérateur d'égalité. </param><filterpriority>3</filterpriority>
        public static bool operator ==(Size sz1, Size sz2);

        /// <summary>
        /// Teste si deux structures <see cref="T:System.Drawing.Size"/> sont différentes.
        /// </summary>
        /// 
        /// <returns>
        /// true si <paramref name="sz1"/> et <paramref name="sz2"/> ont une largeur et une hauteur différentes ; false si <paramref name="sz1"/> et <paramref name="sz2"/> sont égaux.
        /// </returns>
        /// <param name="sz1">Structure <see cref="T:System.Drawing.Size"/> à gauche de l'opérateur d'inégalité. </param><param name="sz2">Structure <see cref="T:System.Drawing.Size"/> à droite de l'opérateur d'inégalité. </param><filterpriority>3</filterpriority>
        [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        public static bool operator !=(Size sz1, Size sz2);

        /// <summary>
        /// Convertit la structure <see cref="T:System.Drawing.Size"/> spécifiée en structure <see cref="T:System.Drawing.Point"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.Point"/> vers laquelle cet opérateur effectue la conversion.
        /// </returns>
        /// <param name="size">Structure <see cref="T:System.Drawing.Size"/> à convertir. </param><filterpriority>3</filterpriority>
        public static explicit operator Point(Size size);

        /// <summary>
        /// Ajoute la largeur et la hauteur d'une structure <see cref="T:System.Drawing.Size"/> à la largeur et la hauteur d'une autre structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.Size"/> qui est le résultat de l'opération d'addition.
        /// </returns>
        /// <param name="sz1">Première structure <see cref="T:System.Drawing.Size"/> à ajouter.</param><param name="sz2">Deuxième structure <see cref="T:System.Drawing.Size"/> à ajouter.</param>
        public static Size Add(Size sz1, Size sz2);

        /// <summary>
        /// Convertit la structure <see cref="T:System.Drawing.SizeF"/> spécifiée en structure <see cref="T:System.Drawing.Size"/> en arrondissant les valeurs de la structure <see cref="T:System.Drawing.Size"/> aux valeurs entières supérieures.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.Size"/> dans laquelle cette méthode effectue une conversion.
        /// </returns>
        /// <param name="value">Structure <see cref="T:System.Drawing.SizeF"/> à convertir. </param><filterpriority>1</filterpriority>
        public static Size Ceiling(SizeF value);

        /// <summary>
        /// Soustrait la largeur et la hauteur d'une structure <see cref="T:System.Drawing.Size"/> de la largeur et de la hauteur d'une autre structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.Size"/> qui est un résultat de l'opération de soustraction.
        /// </returns>
        /// <param name="sz1">Structure <see cref="T:System.Drawing.Size"/> à gauche de l'opérateur de soustraction. </param><param name="sz2">Structure <see cref="T:System.Drawing.Size"/> à droite de l'opérateur de soustraction. </param>
        public static Size Subtract(Size sz1, Size sz2);

        /// <summary>
        /// Convertit la structure <see cref="T:System.Drawing.SizeF"/> spécifiée en structure <see cref="T:System.Drawing.Size"/> en tronquant les valeurs de la structure <see cref="T:System.Drawing.SizeF"/> aux valeurs entières inférieures suivantes.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.Size"/> dans laquelle cette méthode effectue une conversion.
        /// </returns>
        /// <param name="value">Structure <see cref="T:System.Drawing.SizeF"/> à convertir. </param><filterpriority>1</filterpriority>
        public static Size Truncate(SizeF value);

        /// <summary>
        /// Convertit la structure <see cref="T:System.Drawing.SizeF"/> spécifiée en structure <see cref="T:System.Drawing.Size"/> en arrondissant les valeurs de la structure <see cref="T:System.Drawing.SizeF"/> aux valeurs entières les plus proches.
        /// </summary>
        /// 
        /// <returns>
        /// Structure <see cref="T:System.Drawing.Size"/> dans laquelle cette méthode effectue une conversion.
        /// </returns>
        /// <param name="value">Structure <see cref="T:System.Drawing.SizeF"/> à convertir. </param><filterpriority>1</filterpriority>
        public static Size Round(SizeF value);

        /// <summary>
        /// Teste si l'objet spécifié est une structure <see cref="T:System.Drawing.Size"/> avec les mêmes dimensions que cette structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// true si <paramref name="obj"/> est un <see cref="T:System.Drawing.Size"/> et a la même largeur et la même hauteur que ce <see cref="T:System.Drawing.Size"/> ; sinon, false.
        /// </returns>
        /// <param name="obj"><see cref="T:System.Object"/> à tester. </param><filterpriority>1</filterpriority>
        public override bool Equals(object obj);

        /// <summary>
        /// Retourne un code de hachage pour cette structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Valeur entière qui spécifie une valeur de hachage pour cette structure <see cref="T:System.Drawing.Size"/>.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public override int GetHashCode();

        /// <summary>
        /// Crée une chaîne explicite qui représente cette structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Chaîne qui représente ce <see cref="T:System.Drawing.Size"/>.
        /// </returns>
        /// <filterpriority>1</filterpriority><PermissionSet><IPermission class="System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.3600.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" version="1" Flags="UnmanagedCode"/></PermissionSet>
        public override string ToString();

        /// <summary>
        /// Teste si la largeur et la hauteur de cette structure <see cref="T:System.Drawing.Size"/> est égale à 0.
        /// </summary>
        /// 
        /// <returns>
        /// Cette propriété retourne true si la largeur et la hauteur de cette structure <see cref="T:System.Drawing.Size"/> est égale à 0 ; sinon, false.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        [Browsable(false)]
        public bool IsEmpty { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; }

        /// <summary>
        /// Obtient ou définit le composant horizontal de cette structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Composant horizontal de cette structure <see cref="T:System.Drawing.Size"/>, généralement mesuré en pixels.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public int Width { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; set; }

        /// <summary>
        /// Obtient ou définit le composant vertical de cette structure <see cref="T:System.Drawing.Size"/>.
        /// </summary>
        /// 
        /// <returns>
        /// Composant vertical de cette structure <see cref="T:System.Drawing.Size"/>, généralement mesuré en pixels.
        /// </returns>
        /// <filterpriority>1</filterpriority>
        public int Height { [TargetedPatchingOptOut("Performance critical to inline across NGen image boundaries")]
        get; set; }
    }
}

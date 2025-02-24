// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DirectWrite;

public unsafe static class DWriteFontFamilyVtblExtensions
{
    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily> thisVtbl, Guid* riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObject);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily> thisVtbl, Guid* riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (void** ppvObjectPtr = &ppvObject)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riid, ppvObjectPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily> thisVtbl, ref Guid riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObject);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily> thisVtbl, ref Guid riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (Guid* riidPtr = &riid)
        {
            fixed (void** ppvObjectPtr = &ppvObject)
            {
                ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, Guid*, void**, int>)@this->LpVtbl[0])(@this, riidPtr, ppvObjectPtr);
            }
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint AddRef(this ComPtr<IDWriteFontFamily> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint>)@this->LpVtbl[1])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint Release(this ComPtr<IDWriteFontFamily> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint>)@this->LpVtbl[2])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteFontFamily> thisVtbl, IDWriteFontCollection** fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, IDWriteFontCollection**, int>)@this->LpVtbl[3])(@this, fontCollection);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFontCollection(this ComPtr<IDWriteFontFamily> thisVtbl, ref IDWriteFontCollection* fontCollection)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontCollection** fontCollectionPtr = &fontCollection)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, IDWriteFontCollection**, int>)@this->LpVtbl[3])(@this, fontCollectionPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static uint GetFontCount(this ComPtr<IDWriteFontFamily> thisVtbl)
    {
        var @this = thisVtbl.Handle;
        uint ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint>)@this->LpVtbl[4])(@this);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFont(this ComPtr<IDWriteFontFamily> thisVtbl, uint index, IDWriteFont** font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint, IDWriteFont**, int>)@this->LpVtbl[5])(@this, index, font);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFont(this ComPtr<IDWriteFontFamily> thisVtbl, uint index, ref IDWriteFont* font)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont** fontPtr = &font)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, uint, IDWriteFont**, int>)@this->LpVtbl[5])(@this, index, fontPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFamilyNames(this ComPtr<IDWriteFontFamily> thisVtbl, IDWriteLocalizedStrings** names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[6])(@this, names);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFamilyNames(this ComPtr<IDWriteFontFamily> thisVtbl, ref IDWriteLocalizedStrings* names)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteLocalizedStrings** namesPtr = &names)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, IDWriteLocalizedStrings**, int>)@this->LpVtbl[6])(@this, namesPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFirstMatchingFont(this ComPtr<IDWriteFontFamily> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFont** matchingFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, FontWeight, FontStretch, FontStyle, IDWriteFont**, int>)@this->LpVtbl[7])(@this, weight, stretch, style, matchingFont);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetFirstMatchingFont(this ComPtr<IDWriteFontFamily> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, ref IDWriteFont* matchingFont)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFont** matchingFontPtr = &matchingFont)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, FontWeight, FontStretch, FontStyle, IDWriteFont**, int>)@this->LpVtbl[7])(@this, weight, stretch, style, matchingFontPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontFamily> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, IDWriteFontList** matchingFonts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, FontWeight, FontStretch, FontStyle, IDWriteFontList**, int>)@this->LpVtbl[8])(@this, weight, stretch, style, matchingFonts);
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static unsafe int GetMatchingFonts(this ComPtr<IDWriteFontFamily> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, ref IDWriteFontList* matchingFonts)
    {
        var @this = thisVtbl.Handle;
        int ret = default;
        fixed (IDWriteFontList** matchingFontsPtr = &matchingFonts)
        {
            ret = ((delegate* unmanaged[Stdcall]<IDWriteFontFamily*, FontWeight, FontStretch, FontStyle, IDWriteFontList**, int>)@this->LpVtbl[8])(@this, weight, stretch, style, matchingFontsPtr);
        }
        return ret;
    }

    /// <summary>To be documented.</summary>
    public static int QueryInterface<TI0>(this ComPtr<IDWriteFontFamily> thisVtbl, out ComPtr<TI0> ppvObject) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        ppvObject = default;
        return @this->QueryInterface(SilkMarshal.GuidPtrOf<TI0>(), (void**) ppvObject.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily> thisVtbl, Span<Guid> riid, void** ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static unsafe int QueryInterface(this ComPtr<IDWriteFontFamily> thisVtbl, Span<Guid> riid, ref void* ppvObject)
    {
        var @this = thisVtbl.Handle;
        // SpanOverloader
        return @this->QueryInterface(ref riid.GetPinnableReference(), ref ppvObject);
    }

    /// <summary>To be documented.</summary>
    public static int GetFontCollection<TI0>(this ComPtr<IDWriteFontFamily> thisVtbl, ref ComPtr<TI0> fontCollection) where TI0 : unmanaged, IComVtbl<IDWriteFontCollection>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFontCollection((IDWriteFontCollection**) fontCollection.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFont<TI0>(this ComPtr<IDWriteFontFamily> thisVtbl, uint index, ref ComPtr<TI0> font) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFont(index, (IDWriteFont**) font.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFamilyNames<TI0>(this ComPtr<IDWriteFontFamily> thisVtbl, ref ComPtr<TI0> names) where TI0 : unmanaged, IComVtbl<IDWriteLocalizedStrings>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFamilyNames((IDWriteLocalizedStrings**) names.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetFirstMatchingFont<TI0>(this ComPtr<IDWriteFontFamily> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, ref ComPtr<TI0> matchingFont) where TI0 : unmanaged, IComVtbl<IDWriteFont>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetFirstMatchingFont(weight, stretch, style, (IDWriteFont**) matchingFont.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static int GetMatchingFonts<TI0>(this ComPtr<IDWriteFontFamily> thisVtbl, FontWeight weight, FontStretch stretch, FontStyle style, ref ComPtr<TI0> matchingFonts) where TI0 : unmanaged, IComVtbl<IDWriteFontList>, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // ComPtrOverloader
        return @this->GetMatchingFonts(weight, stretch, style, (IDWriteFontList**) matchingFonts.GetAddressOf());
    }

    /// <summary>To be documented.</summary>
    public static ComPtr<TI0> QueryInterface<TI0>(this ComPtr<IDWriteFontFamily> thisVtbl) where TI0 : unmanaged, IComVtbl<TI0>
    {
        var @this = thisVtbl.Handle;
        // NonKhrReturnTypeOverloader
        SilkMarshal.ThrowHResult(@this->QueryInterface(out ComPtr<TI0> silkRet));
        return silkRet;
    }

}

﻿/*
* This template uses the TsT - Typewriter.
* Read more at :
* -- https://github.com/frhagn/Typewriter (Github)
* -- https://marketplace.visualstudio.com/items?itemName=frhagn.Typewriter  (Extension of Visual Studio 17)
* -- http://frhagn.github.io/Typewriter/ (Documentation)
*/

/* tslint:disable*/

declare namespace Nicollas.Dto.Identity {

	interface userLoginDto  { 
        loginProvider: string;
        providerKey: string;
        providerDisplayName: string;
        userId: string;
        user: Nicollas.Dto.Identity.userDto;
    }
}
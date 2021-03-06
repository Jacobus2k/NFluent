﻿// // --------------------------------------------------------------------------------------------------------------------
// // <copyright file="IMustImplementIForkableCheckWithoutDisplayingItsMethodsWithinIntelliSense.cs" company="">
// //   Copyright 2013 Thomas PIERRAIN
// //   Licensed under the Apache License, Version 2.0 (the "License");
// //   you may not use this file except in compliance with the License.
// //   You may obtain a copy of the License at
// //       http://www.apache.org/licenses/LICENSE-2.0
// //   Unless required by applicable law or agreed to in writing, software
// //   distributed under the License is distributed on an "AS IS" BASIS,
// //   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// //   See the License for the specific language governing permissions and
// //   limitations under the License.
// // </copyright>
// // --------------------------------------------------------------------------------------------------------------------
namespace NFluent
{
    /// <summary>
    /// Marker interface indicating that the implementations should implement the <see cref="IForkableCheck"/> interface.
    /// This is a 'trick' so that the <see cref="IForkableCheck"/> methods don't appeared in the user Intellisense.
    /// </summary>
    public interface IMustImplementIForkableCheckWithoutDisplayingItsMethodsWithinIntelliSense
    {
    }
}
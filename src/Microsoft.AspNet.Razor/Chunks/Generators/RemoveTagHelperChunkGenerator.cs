// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Razor.Parser.SyntaxTree;

namespace Microsoft.AspNet.Razor.Chunks.Generators
{
    /// <summary>
    /// A <see cref="SpanChunkGenerator"/> responsible for generating <see cref="RemoveTagHelperChunk"/>s.
    /// </summary>
    public class RemoveTagHelperChunkGenerator : SpanChunkGenerator
    {
        /// <summary>
        /// Generates <see cref="RemoveTagHelperChunk"/>s.
        /// </summary>
        /// <param name="target">
        /// The <see cref="Span"/> responsible for this <see cref="RemoveTagHelperChunkGenerator"/>.
        /// </param>
        /// <param name="context">A <see cref="ChunkGeneratorContext"/> instance that contains information about
        /// the current chunk generation process.</param>
        public override void GenerateChunk(Span target, ChunkGeneratorContext context)
        {
            var lookupText = target.Content.Trim();

            context.ChunkTreeBuilder.AddRemoveTagHelperChunk(lookupText, target);
        }
    }
}
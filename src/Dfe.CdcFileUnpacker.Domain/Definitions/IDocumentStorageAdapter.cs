﻿namespace Dfe.CdcFileUnpacker.Domain.Definitions
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Describes the operations of the document storage adapter.
    /// </summary>
    public interface IDocumentStorageAdapter
    {
        /// <summary>
        /// Lists the names of directories for a given
        /// <paramref name="rootDirectory" />.
        /// </summary>
        /// <param name="rootDirectory">
        /// The root directory in which to list directories for.
        /// </param>
        /// <param name="cancellationToken">
        /// An instance of type <see cref="CancellationToken" />.
        /// </param>
        /// <returns>
        /// An instance of type <see cref="IEnumerable{String}" />.
        /// </returns>
        Task<IEnumerable<string>> ListDirectoriesAsync(
            string rootDirectory,
            CancellationToken cancellationToken);
    }
}
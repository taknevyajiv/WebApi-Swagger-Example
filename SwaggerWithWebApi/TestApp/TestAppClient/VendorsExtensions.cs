﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TestApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Vendors.
    /// </summary>
    public static partial class VendorsExtensions
    {
            /// <summary>
            /// This operation retrieves all the available vendors for AdventureWorks
            /// company
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Vendor> GetVendors(this IVendors operations)
            {
                return Task.Factory.StartNew(s => ((IVendors)s).GetVendorsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation retrieves all the available vendors for AdventureWorks
            /// company
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Vendor>> GetVendorsAsync(this IVendors operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVendorsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation is to create a new vendor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vendor'>
            /// Vendor details
            /// </param>
            public static Vendor PostVendor(this IVendors operations, Vendor vendor)
            {
                return Task.Factory.StartNew(s => ((IVendors)s).PostVendorAsync(vendor), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation is to create a new vendor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='vendor'>
            /// Vendor details
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Vendor> PostVendorAsync(this IVendors operations, Vendor vendor, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostVendorWithHttpMessagesAsync(vendor, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation retrieves a single vendor for corresponding ID passed in
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Vendor ID
            /// </param>
            public static Vendor GetVendor(this IVendors operations, int id)
            {
                return Task.Factory.StartNew(s => ((IVendors)s).GetVendorAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation retrieves a single vendor for corresponding ID passed in
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Vendor ID
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Vendor> GetVendorAsync(this IVendors operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetVendorWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This operation is to update an existing vendor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Vendor ID
            /// </param>
            /// <param name='vendor'>
            /// Vendor object to be modified
            /// </param>
            public static void PutVendor(this IVendors operations, int id, Vendor vendor)
            {
                Task.Factory.StartNew(s => ((IVendors)s).PutVendorAsync(id, vendor), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation is to update an existing vendor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// Vendor ID
            /// </param>
            /// <param name='vendor'>
            /// Vendor object to be modified
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutVendorAsync(this IVendors operations, int id, Vendor vendor, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutVendorWithHttpMessagesAsync(id, vendor, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// This operation is to delete an existing vendor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// ID of the vendor to be deleted
            /// </param>
            public static Vendor DeleteVendor(this IVendors operations, int id)
            {
                return Task.Factory.StartNew(s => ((IVendors)s).DeleteVendorAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// This operation is to delete an existing vendor
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// ID of the vendor to be deleted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Vendor> DeleteVendorAsync(this IVendors operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteVendorWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
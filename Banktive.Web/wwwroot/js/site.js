﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {

    $('.balanceCBDCXRPLWallet').each(function () {
        var walletId = $(this).data('walletid');
        fetch('/Wallet/GetNativeBalance/' + walletId, {
            method: "GET",
            headers: { "Content-type": "application/json;charset=UTF-8" }
        })
            .then(response => response.json())
            .then(json =>
                $(this).text(json.valueAsXrp)
            )
            .catch(err => console.log(err));
    });
})

async function generateFundAddress() {
    const client = new xrpl.Client("wss://s.altnet.rippletest.net:51233");
    await client.connect()
    const my_wallet = (await client.fundWallet()).wallet;
    if (my_wallet != null) {
        $('#Form_XRPLAddress').val(my_wallet.address);
        $('#Form_XRPLSeed').val(my_wallet.seed);
        $('#createWalletBtn').prop('disabled', 'false');
    }
    
    client.disconnect();
}
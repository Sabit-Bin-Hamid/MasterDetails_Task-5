

$(document).ready(function () {

});

$("#AddButton").click(function () {

    CreateRowForPurchase();
})

function CreateRowForPurchase() {
    var selectedItem = getselectedItem();
    //get existing row number
    var index = $("#purchaseDetailsTable").children("tr").length;
    //sl for Ui serial number
    var sl = index;
    //for Mvc Array index set
    var indexCell = "<td style='display:none'> <input type='hidden' id='index" + index + "' name='PurchaseDetails.Index' value='" + index + "' /></td>";

    var serialCell = "<td> " + (++sl) + " </td>";
    //binding value from ui through jQuary (create cell)
    var ItemCodeForCell = "<td> <input type='hidden' id='ItemCodeFor" + index + "' name='PurchaseDetails[" + index + "].ItemCode' value='" + selectedItem.ItemCodeFor + "' />" + selectedItem.ItemCodeFor + "</td>";
    var PurchaseIdNoCell = "<td> <input type='hidden' id='PurchaseIdNo" + index + "' name='PurchaseDetails[" + index + "].PurchaseId' value='" + selectedItem.PurchaseIdNo + "' />" + selectedItem.PurchaseIdNo + "</td>";
    var ItemQuantityCell = "<td> <input type='hidden' id='ItemQuantity" + index + "' name='PurchaseDetails[" + index + "].ItemQty' value='" + selectedItem.ItemQuantity + "' />" + selectedItem.ItemQuantity + "</td>";
    var ItemUnitIdNoCell = "<td> <input type='hidden' id='ItemUnitIdNo" + index + "' name='PurchaseDetails[" + index + "].ItemUnitId' value='" + selectedItem.ItemUnitIdNo + "' />" + selectedItem.ItemUnitIdNo + "</td>";
    var ItemRateNoCell = "<td> <input type='hidden' id='ItemRateNo" + index + "' name='PurchaseDetails[" + index + "].ItemRate' value='" + selectedItem.ItemRateNo + "' />" + selectedItem.ItemRateNo + "</td>";


    //create the Row
    var createNewRow = "<tr>" + indexCell + serialCell + PurchaseIdNoCell + ItemCodeForCell + ItemQuantityCell + ItemUnitIdNoCell + ItemRateNoCell + "</tr>";

    var allProductsFieldAreFillUp = AllFieldAreGiven();

    //adding to table
    if (allProductsFieldAreFillUp) {
        $("#purchaseDetailsTable").append(createNewRow);
        //after adding making the box empty
        $("#ItemCodeFor").val("");
        $("#PurchaseIdNo").val("");
        $("#ItemQuantity").val("");
        $("#ItemUnitIdNo").val("");
        $("#ItemRateNo").val("");
        
    } else {
        alert("Problem In request. May be all PurchaseDetailes Filed are not fillup ");
        $('#ItemCodeFor').val();
        $('#PurchaseIdNo').val();
        $('#ItemQuantity').val();
        $('#ItemUnitIdNo').val();
        $('#ItemRateNo').val();

    }
}


function getselectedItem() {
    //for validation and get value

    
    var ItemCodeFor = $("#ItemCodeFor").val();
    var PurchaseIdNo = $("#PurchaseIdNo").val();
    var ItemQuantity = $("#ItemQuantity").val();
    var ItemUnitIdNo = $("#ItemUnitIdNo").val();
    var ItemRateNo = $("#ItemRateNo").val();

    var item = {
        "ItemCodeFor": ItemCodeFor,
        "ItemQuantity": ItemQuantity,
        "PurchaseIdNo": PurchaseIdNo,
        "ItemUnitIdNo": ItemUnitIdNo,
        "ItemRateNo": ItemRateNo
    }
    return item;
}


function AllFieldAreGiven() {
    let res;
    var ItemCodeFor = $("#ItemCodeFor").val();
    var PurchaseIdNo = $("#PurchaseIdNo").val();
    var ItemQuantity = $("#ItemQuantity").val();
    var ItemUnitIdNo = $("#ItemUnitIdNo").val();
    var ItemRateNo = $("#ItemRateNo").val();

    if (ItemCodeFor.length > 0 && PurchaseIdNo.length > 0 && ItemQuantity.length > 0 && ItemUnitIdNo.length > 0 && ItemRateNo.length > 0) {
        res = true;
    } else {
        res = false;
    }
    return res
}

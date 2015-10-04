﻿<%@ Page Title="Claims" Language="C#" MasterPageFile="~/UbietyMenu.Master" AutoEventWireup="true" CodeBehind="claim.aspx.cs" Inherits="adminpanel.claim" %>

<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <div class="row wrapper border-bottom white-bg page-heading">
        <div class="col-lg-10">
            <h2>Add A New Claim</h2>
        </div>
        <div class="col-lg-2">

        </div>
    </div>

    <br />

    <div class="col-lg-10 col-sm-12 col-md-12 col-lg-offset-1">
        <div class="ibox">
            <div class="ibox-content">
                <div class="tabs-container">
                    <div class="tabs-top">
                        <ul class="nav nav-tabs">
                            <li><a data-toggle="tab" href="#tabSummary">Summary</a></li>
                            <li class="active"><a data-toggle="tab" href="#tabTravel">Travel</a></li>
                            <li><a data-toggle="tab" href="#tabHotel">Hotel</a></li>
                            <li><a data-toggle="tab" href="#tabFood">Food</a></li>
                            <li><a data-toggle="tab" href="#tabOthers">Others</a></li>

                        </ul>
                        <div class="tab-content ">

                            <div id="tabSummary" class="tab-pane">
                                <div class="panel-body">
                                    <div class="row">

                                        <div class="col-lg-8 col-sm-8 col-md-8">
                                            <form method="get" class="form-horizontal">

                                                <div class="form-group">
                                                    <label class="col-sm-2 control-label">Purpose</label>
                                                    <div class="col-sm-10">
                                                        <input type="text" class="form-control" />
                                                    </div>
                                                </div>

                                                <div class="hr-line-dashed"></div>
                                                <div class="form-group">
                                                    <label class="col-sm-2 control-label">Date</label>

                                                    <div class="col-sm-4">
                                                        <div class="input-group m-b"><span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                            <input type="date" class="form-control" /></div>
                                                    </div>
                                                    <label class="col-sm-2 control-label">Status</label>

                                                    <div class="col-sm-4">
                                                        <input type="text" class="form-control" />
                                                    </div>
                                                </div>
                                                <hr class="hr-line-dashed" style="margin-top: 0px" />
                                                <div class="form-group">
                                                    <label class="col-sm-2 control-label">Manager</label>

                                                    <div class="col-sm-10">
                                                        <input type="text" class="form-control" />
                                                    </div>

                                                </div>
                                            </form>
                                        </div>
                                        <div class="col-lg-4 col-sm-4 col-md-4">
                                            <table class="table table-bordered">
                                                <thead>
                                                    <tr>
                                                        <th style="width: 65%">Expense</th>
                                                        <th>Amount ( &#x20B9 )</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr>
                                                        <td>Travel</td>
                                                        <td class="curr" id="sumTravelAmt">0.00</td>
                                                    </tr>
                                                    <tr>
                                                        <td>Hotel</td>
                                                        <td class="curr" id="sumHotelAmt">0.00</td>

                                                    </tr>
                                                    <tr>
                                                        <td>Food</td>
                                                        <td class="curr" id="sumFoodAmt">0.00</td>

                                                    </tr>

                                                    <tr>
                                                        <td>Others</td>
                                                        <td class="curr" id="summOthAmt">0.00</td>

                                                    </tr>
                                                </tbody>
                                                <tfoot>
                                                    <tr style="background-color: lightgray">
                                                        <td><b>Total</b></td>
                                                        <td class="curr" ><b id="summTotAmt">0.00</b></td>
                                                    </tr>
                                                </tfoot>
                                            </table>
                                        </div>

                                    </div>
                                    <div class="hr-line-dashed" style="margin-top: 0px"></div>
                                    <div class="row">
                                        <div class="col-lg-12">
                                            <table class=" table table-stripped table-bordered table-hover table-condensed">
                                                <thead>
                                                    <tr>
                                                        <th style="width: 10%;">Date </th>
                                                        <th style="width: 70%">Purpose</th>
                                                        <th style="width: 10%" class="curr">Amount</th>
                                                        <th style="width: 10%">Manage</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
                                                    <tr>
                                                        <td>Travel</td>
                                                        <td>Purpose</td>
                                                        <td class="curr">0.00</td>
                                                        <td class="text-center text-info"><i class="fa fa-pencil"></i>&nbsp;&nbsp;  <i class="fa fa-trash"></i></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Travel</td>
                                                        <td>Purpose</td>
                                                        <td class="curr">0.00</td>
                                                        <td class="text-center text-info"><i class="fa fa-pencil"></i>&nbsp;&nbsp;  <i class="fa fa-trash "></i></td>
                                                    </tr>
                                                    <tr>
                                                        <td>Travel</td>
                                                        <td>Purpose</td>
                                                        <td class="curr">0.00</td>
                                                        <td class="text-center text-info"><i class="fa fa-pencil "></i>&nbsp;&nbsp;  <i class="fa fa-trash "></i></td>
                                                    </tr>
                                                </tbody>

                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div id="tabTravel" class="tab-pane">
                                <div class="panel-body">

                                    <form method="get" class="form-horizontal">

                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Travel Purpose</label>
                                            <div class="col-sm-10">
                                                <input type="text" id="travelpurpose" class="form-control" />
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Travel Date</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                    <input type="date" id="traveldate" class="form-control" />
                                                </div>
                                            </div>
                                            <label class="col-sm-2 control-label">Mode of Travel</label>
                                            <div class="col-sm-4">
                                                <label class="checkbox-inline">
                                                    <input type="radio" name="modeoftravel" value="Auto" id="inlineCheckbox1" />
                                                    Auto </label>
                                                <label class="checkbox-inline">
                                                    <input type="radio" value="Train" name="modeoftravel" id="inlineCheckbox2" />
                                                    Train
                                                </label>
                                                <label class="checkbox-inline">
                                                    <input type="radio" value="Bus" name="modeoftravel" id="inlineCheckbox3" />
                                                    Bus
                                                </label>
                                            </div>

                                        </div>
                                        <div class="hr-line-dashed"></div>

                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">From</label>
                                            <div class="col-sm-4">
                                                <input type="text" id="travelfrom" class="form-control" />


                                            </div>
                                            <label class="col-sm-2 control-label">To</label>
                                            <div class="col-sm-4">
                                                <input type="text" id="travelto" class="form-control" />
                                            </div>
                                        </div>

                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Distance</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <input type="text" id="traveldistance" class="form-control" /><span class="input-group-addon">Kms</span></div>
                                            </div>
                                            <label class="col-sm-2 control-label">Rate</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon">&#x20B9</span>
                                                    <input type="text" id="travelrate" class="form-control" />
                                                    <span class="input-group-addon">per km</span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Remarks</label>
                                            <div class="col-sm-10">
                                                <input type="text" id="travelremarks" class="form-control" />
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Total Amount</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon">&#x20B9</span>
                                                    <input type="number" id="travelamount" class="form-control" />
                                                </div>
                                            </div>
                                            <div class="col-sm-6">
            
                                                <input type="button" id="travelButton" class="pull-right btn btn-success" value="Add Expense" onclick="addExpense('Travel')" />
                                            </div>
                                        </div>
                                    </form>

                                </div>
                            </div>

                            <div id="tabHotel" class="tab-pane">
                                <div class="panel-body">

                                    <form method="get" class="form-horizontal">

                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Hotel Name</label>
                                            <div class="col-sm-10">
                                                <input type="text" id="hotelname" class="form-control" />
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Stay From Date</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                    <input type="date" id="stayfromdate" class="form-control" />
                                                </div>
                                            </div>
                                            <label class="col-sm-2 control-label">Stay To Date</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                    <input type="date" id="staytodate" class="form-control" />
                                                </div>
                                            </div>

                                        </div>
                                        <div class="hr-line-dashed"></div>


                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">No. of Nights</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <input type="number" id="noofnights" class="form-control" /><span class="input-group-addon">Nights</span></div>
                                            </div>
                                            <label class="col-sm-2 control-label">Rate</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon">&#x20B9</span>
                                                    <input type="number" id="hotelrate" class="form-control" />
                                                    <span class="input-group-addon">per night</span>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Remarks</label>
                                            <div class="col-sm-10">
                                                <input type="text" id="hotelremarks" class="form-control" />
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Total Amount</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon">&#x20B9</span>
                                                    <input type="number" id="hotelamount" class="form-control" />
                                                </div>
                                            </div>
                                            <div class="col-sm-6">
                                                <input type="button" onclick="addExpense('Hotel')" class="pull-right btn btn-success" value="Add Expense" />
                                            </div>
                                        </div>
                                    </form>

                                </div>
                            </div>

                            <div id="tabFood" class="tab-pane">
                                <div class="panel-body">

                                    <form method="get" class="form-horizontal">

                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Restaurant Name</label>
                                            <div class="col-sm-10">
                                                <input type="text" id="restaurantname" class="form-control" />
                                            </div>
                                        </div>

                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Expense Date</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b"><span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                    <input type="date" id="foodexpensedate" class="form-control" /></div>
                                            </div>
                                            <label class="col-sm-2 control-label">No. of Persons</label>

                                            <div class="col-sm-4">
                                                <input type="text" id="foodnoofpersons" class="form-control" />
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Remarks</label>
                                            <div class="col-sm-10">
                                                <input type="text" id="foodremarks" class="form-control" />
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Total Amount</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon">&#x20B9</span>
                                                    <input type="number" id="foodtotalamount" class="form-control" />
                                                </div>
                                            </div>
                                            <div class="col-sm-6">
                                                <input type="button" onclick="addExpense('Food')" class="pull-right btn btn-success" value="Add Expense" />
                                            </div>
                                        </div>
                                    </form>

                                </div>
                            </div>

                            <div id="tabOthers" class="tab-pane">
                                <div class="panel-body">
                                    <form method="get" class="form-horizontal">

                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Expense Description</label>
                                            <div class="col-sm-10">
                                                <input type="text" id="otherdesc" class="form-control" />
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Expense Date</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b"><span class="input-group-addon"><i class="fa fa-calendar"></i></span>
                                                    <input type="date" id="otherexpensedate" class="form-control" /></div>
                                            </div>

                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Remarks</label>
                                            <div class="col-sm-10">
                                                <input type="text" id="otherexpenseremarks" class="form-control" />
                                            </div>
                                        </div>
                                        <div class="hr-line-dashed"></div>
                                        <div class="form-group">
                                            <label class="col-sm-2 control-label">Total Amount</label>

                                            <div class="col-sm-4">
                                                <div class="input-group m-b">
                                                    <span class="input-group-addon">&#x20B9</span>
                                                    <input type="number" id="otherexpenseamt" class="form-control" />
                                                </div>
                                            </div>
                                            <div class="col-sm-6">
                                                <input type="button" onclick="addExpense('Others')" class="pull-right btn btn-success" value="Add Expense" />
                                            </div>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>

        var claimJSON = $.parseJSON('{"empid":"","claimpurpose":"","claimdate":"","totalamount":"","managername":"","status":"","Travels":[],"Hotels":[],"Food":[],"Others":[]}');
        function addExpense(expenseType) {
            switch (expenseType) {
                case 'Travel':
                    claimJSON.Travels.push({ "purpose": $('#travelpurpose').val(), "traveldate": $("#traveldate").val(), "modeoftravel": $('input[name=modeoftravel]:checked').val(), "from": $("#travelfrom").val(), "to": $("#travelto").val(), "distance": $("#traveldistance").val(), "rate": $("#travelrate").val(), "remarks": $("#travelremarks").val(), "totalamount": $("#travelamount").val() });
                    calculateSummTravelAmt();
                    break;
                case 'Hotel':
                    claimJSON.Hotels.push({ "hotelname": $("#hotelname").val(), "stayfromdate": $("#stayfromdate").val(), "staytodate": $("#staytodate").val(), "noofnights": $("#").val(), "rate": $("#hotelrate").val(), "remarks": $("#hotelremarks").val(), "totalamount": $("#hotelamount").val() });
                    calculateSummHotelAmt();
                    break;
                case 'Food':
                    claimJSON.Food.push({"restaurantname":$("#restaurantname").val(),"expensedate":$("#foodexpensedate").val(),"noofpersons":$("#foodnoofpersons").val(),"remarks":$("#foodremarks").val(),"totalamount":$("#foodtotalamount").val()});
                    calculateSummFoodAmt();
                    break;
                case 'Others':
                    claimJSON.Others.push({"otherdesc":$("#otherdesc").val(), "otherexpensedate": $("#otherexpensedate").val(), "otherexpenseremarks":$("#otherexpenseremarks").val(), "otherexpenseamt": $("#otherexpenseamt").val() });
                    calculateSummOthersAmt();
                    break;

                default:

                
            }
            calculateTotalAmt();
        }

        

        function calculateTotalAmt() {
             var totamt = parseInt($("#sumTravelAmt").html()) + parseInt($("#sumHotelAmt").html())  + parseInt($("#sumFoodAmt").html())  + parseInt($("#summOthAmt").html()) ; 
            
        $("#summTotAmt").html( totamt);
        }

        function calculateSummTravelAmt() {
            var i = claimJSON.Travels.length;
            var p;
            var totAmt = 0;
            
            for (p = 0; p < i; p++) {
                totAmt += parseInt(claimJSON.Travels[p].totalamount);
            }
            alert(totAmt);
            $("#sumTravelAmt").html(totAmt );
        }


        function calculateSummHotelAmt() {
            var i = claimJSON.Hotels.length;
            var p;
            var totAmt = 0;
            
            for (p = 0; p < i; p++) {
                totAmt += parseInt(claimJSON.Hotels[p].totalamount);
            }

            $("#sumHotelAmt").html(totAmt);
        }

        function calculateSummFoodAmt() {
            var i = claimJSON.Food.length;
            var p;
            var totAmt = 0;
            
            for (p = 0; p < i; p++) {
                totAmt += parseInt(claimJSON.Food[p].totalamount);
            }

            $("#sumFoodAmt").html(totAmt);
        }

        function calculateSummOthersAmt() {
            var i = claimJSON.Others.length;
            var p;
            var totAmt = 0;
            
            for (p = 0; p < i; p++) {
                totAmt += parseInt(claimJSON.Others[p].otherexpenseamt);
            }

            $("#summOthAmt").html(totAmt);
        }



    </script>
</asp:Content>

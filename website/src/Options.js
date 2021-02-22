import React, { Component } from 'react';

// sidebar component that lets the user specify which options they want
export class Options extends Component {

    // every time they pick an option update the querystring and send it back to the parent to update the inventory
    selectChange = () => {
        let selects = document.getElementsByTagName("select");
        let query = "?";
        for(let i = 0; i < selects.length; ++i) {
            query += `${selects[i].id}=${selects[i].value}&`
        };
        query = query.substring(0, query.length -1);
        this.props.update(query);
    }

    render() {
        return <div className="col-4 p-2">
            <h2 className="text-center">Options</h2>
            <div className="row m-2 p-2">
                Color: <select id="color" className="ml-2" onChange={this.selectChange}>
                    <option value="null">No Preference</option>
                    <option value="Red">Red</option>
                    <option value="White">White</option>
                    <option value="Gray">Gray</option>
                    <option value="Silver">Silver</option>
                    <option value="Black">Black</option>
                </select>
            </div>
            <div className="row m-2 p-2">
                Sunroof: <select id="hasSunroof" className="ml-2" onChange={this.selectChange}>
                    <option value="null">No Preference</option>
                    <option value="true">Included</option>
                    <option value="false">Not Included</option>
                </select>
            </div>
            <div className="row m-2 p-2">
                Four Wheel Drive: <select id="isFourWheelDrive" className="ml-2" onChange={this.selectChange}>
                    <option value="null">No Preference</option>
                    <option value="true">Included</option>
                    <option value="false">Not Included</option>
                </select>
            </div>
            <div className="row m-2 p-2">
                Low Miles: <select id="hasLowMiles" className="ml-2" onChange={this.selectChange}>
                    <option value="null">No Preference</option>
                    <option value="true">Included</option>
                    <option value="false">Not Included</option>
                </select>
            </div>
            <div className="row m-2 p-2">
                Power Windows: <select id="hasPowerWindows" className="ml-2" onChange={this.selectChange}>
                    <option value="null">No Preference</option>
                    <option value="true">Included</option>
                    <option value="false">Not Included</option>
                </select>
            </div>
            <div className="row m-2 p-2">
                Navigation: <select id="hasNavigation" className="ml-2" onChange={this.selectChange}>
                    <option value="null">No Preference</option>
                    <option value="true">Included</option>
                    <option value="false">Not Included</option>
                </select>
            </div>
            <div className="row m-2 p-2">
                Heated Seats: <select id="hasHeatedSeats" className="ml-2" onChange={this.selectChange}>
                    <option value="null">No Preference</option>
                    <option value="true">Included</option>
                    <option value="false">Not Included</option>
                </select>
            </div>
      </div>

    }
}
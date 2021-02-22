import React, { Component } from 'react';

// component to fill in the extras column of the inventory report
export class Extras extends Component {
    getExtras = () => {
        let extras = "";
        if (this.props.car) {
            if (this.props.car.hasSunroof) {
                extras +=  "Sunroof, ";
            }
            if (this.props.car.isFourWheelDrive) {
                extras +=  "Four Wheel Drive, ";
            }
            if (this.props.car.hasLowMiles) {
                extras += "Low Milage, ";
            }
            if (this.props.car.hasPowerWindows) {
                extras += "PowerWindows, ";
            }
            if (this.props.car.hasNavigation) {
                extras += "Navigation, ";
            }
            if (this.props.car.hasHeatedSeats) {
                extras += "Heated Seats, ";
            }
        }
        if (extras.length > 0) {
            extras = extras.substring(0, extras.length - 2);
        }
        return extras;
    }
    render() {
        return <span>
            { this.getExtras() }
        </span>
    }
}
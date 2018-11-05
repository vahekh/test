import React, { Component } from 'react';

export class HelloMessage extends Component {
    render() {
        return (
            <div>
                Hello, {formatName(user)}!
                Hello {this.props.name}
            </div>
        );
    }
}

function formatName(user) {
    return user.firstName + ' ' + user.lastName;
}

const user = {
    firstName: 'Harper',
    lastName: 'Perez'
};


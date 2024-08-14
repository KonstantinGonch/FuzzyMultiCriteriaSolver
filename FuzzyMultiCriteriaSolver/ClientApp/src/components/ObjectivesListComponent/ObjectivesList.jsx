import React, { useEffect, useState } from 'react';
import ListGroup from 'react-bootstrap/ListGroup';
import axios from 'axios';

function ObjectivesList() {

    const [objectives, setObjectives] = useState([]);

    useEffect(() => {
        axios.get('/api/objectives/all')
            .then(response => {
                setObjectives(response.data);
            })
            .catch(error => {
                console.error('Error getting objectives: ', error);
            });
    }, []);

    const getLink = obj => {
        return `/objective?id=${obj.id}`
	}

    return (
        <div>
            <div className="list-group">
                {objectives.map((obj, i) => {
                    return <a href={getLink(obj)} className="list-group-item-action list-group-item">
                        {obj.title}
                    </a>
			    })}
            </div>
        </div>
    );
}

export default ObjectivesList;

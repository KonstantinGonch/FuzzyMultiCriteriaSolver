import React, { useEffect, useState } from 'react';

function DescribeVariables() {

    const [variables, setVariables] = useState([]);
    const [searchParams, setSearchParams] = useSearchParams();

    const loadVariables = (objectiveId) => {
        axios.get(`/api/variables/getObjectiveVariables?objectiveId=${objectiveId}`)
            .then(response => {
                setVariables(response.data)
            })
            .catch(error => {
                console.error('Error getting variables ', error);
            });
	}

    useEffect(() => {
        const objectiveId = searchParams.get("objectiveId");
	}, [])

    return (
        <div>
            <h2>Описание переменных</h2>
            <div class="panel panel-default">
                <div class="panel-body">A Basic Panel</div>
            </div>
        </div>
    );
}

export default DescribeVariables;

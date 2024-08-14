import React, { useEffect, useState } from 'react';

function DescribeVariableItem({editable, onSaveVariable, variable, objectiveId }) {

    const [title, setTitle] = useState("");
    const [isStrict, setIsStrict] = useState(false);

    useEffect(() => {
        if (variable) {
            setIsStrict(variable.isStrict);
            setTitle(variable.title)
        }
    }, []);

    const doSave = () => {
        const variable = {
            title: title,
            isStrict: isStrict,
            objectiveId: objectiveId
        }

        onSaveVariable(variable);
	}

    return (
        <div className="row col-sm-12 list-group-item" style={{ display: 'inline-flex' }}>
            <div className="col-sm-5" style={{ display: 'inline-flex' }}>
                <label className="form-label col-sm-2">Заголовок</label>
                <input className="form-control" type="text" value={title} onChange={e => setTitle(e.target.value)} disabled={!editable} />
            </div>
            <div className="col-sm-5" style={{ display: 'inline-flex' }}>
                <label className="form-label col-sm-2">Четкая</label>
                <input className="form-check-input" type="checkbox" value={isStrict} checked={isStrict} disabled={!editable} onChange={e => setIsStrict(e.target.checked)} style={{ width: '2em', height: '2em' }} />
            </div>
            <div className="col-sm-2">
                <button className="btn btn-success bi bi-check2" disabled={!editable} onClick={doSave}></button>
            </div>
        </div>
    );
}

export default DescribeVariableItem;
